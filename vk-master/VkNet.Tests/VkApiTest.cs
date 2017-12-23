﻿using System.Linq;
using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using VkNet.Enums;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Tests
{
	[TestFixture]
	public class VkApiTest : BaseTest
	{
		[Test]
		public void VkApi_Constructor_SetDefaultMethodCategories()
		{
			Assert.That(Api.Users, Is.Not.Null);
			Assert.That(Api.Friends, Is.Not.Null);
			Assert.That(Api.Status, Is.Not.Null);
			Assert.That(Api.Messages, Is.Not.Null);
			Assert.That(Api.Groups, Is.Not.Null);
			Assert.That(Api.Audio, Is.Not.Null);
			Assert.That(Api.Wall, Is.Not.Null);
			Assert.That(Api.Database, Is.Not.Null);
			Assert.That(Api.Utils, Is.Not.Null);
			Assert.That(Api.Fave, Is.Not.Null);
			Assert.That(Api.Video, Is.Not.Null);
			Assert.That(Api.Account, Is.Not.Null);
			Assert.That(Api.Photo, Is.Not.Null);
			Assert.That(Api.Docs, Is.Not.Null);
			Assert.That(Api.Likes, Is.Not.Null);
			Assert.That(Api.Pages, Is.Not.Null);
			Assert.That(Api.Gifts, Is.Not.Null);
			Assert.That(Api.Apps, Is.Not.Null);
			Assert.That(Api.NewsFeed, Is.Not.Null);
			Assert.That(Api.Stats, Is.Not.Null);
			Assert.That(Api.Auth, Is.Not.Null);
			Assert.That(Api.Markets, Is.Not.Null);
		}
		
		[Test]
		public void Call_NotMoreThen3CallsPerSecond()
		{
			Json = @"{ ""response"": 2 }";
			Api.RequestsPerSecond = 3; // Переопределение значения в базовом классе
			var invocationCount = 0;
			Mock.Get(Api.Browser)
				.Setup(m => m.GetJson(It.IsAny<string>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>()))
				.Returns(Json)
				.Callback(delegate { invocationCount++; });

			var start = DateTimeOffset.Now;
			while (true)
			{
				Api.Call("someMethod", VkParameters.Empty, true);

				var total = (int)(DateTimeOffset.Now - start).TotalMilliseconds;
				if (total > 999)
				{
					break;
				}
			}

			// Не больше 4 раз, т.к. 4-ый раз вызывается через 1002 мс после первого вызова, а total выходит через 1040 мс
			// переписать тест, когда придумаю более подходящий метод проверки
			Mock.Get(Api.Browser).Verify(m => m.GetJson(It.IsAny<string>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>()), Times.AtMost(4));
		}

		[Test]
		public void Invoke_VkParams()
		{
		    Url = "https://api.vk.com/method/example.get";
            Json = @"{ 'response' : [] }";
            var parameters = new VkParameters { { "count", 23 } };
			var json = Api.Invoke("example.get", parameters, true);

			StringAssert.AreEqualIgnoringCase(json, Json);
		}

		[Test]
		public void Invoke_DictionaryParams()
		{
			Url = "https://api.vk.com/method/example.get";
			Json = @"{ 'response' : [] }";
			var parameters = new Dictionary<string, string> { { "count", "23" } };
			var json = Api.Invoke("example.get", parameters, true);

			StringAssert.AreEqualIgnoringCase(json, Json);
		}

		[Test]
		public void AuthorizeByToken()
		{
			Api.Authorize(new ApiAuthParams
			{
				AccessToken = "token",
				UserId = 1
			});
			Assert.That(Api.UserId, Is.EqualTo(1));
		}

        [Test]
	    public void VkCallShouldBePublic()
        {
            // arrange
            var myType = (typeof(VkApi));
            var myArrayMethodInfo = myType.GetMethods();

            // act
            var callMethod = myArrayMethodInfo.FirstOrDefault(x => x.Name.Contains("Call"));

            // Assert
            Assert.IsNotNull(callMethod);
            Assert.IsTrue(callMethod.IsPublic);
        }

		[Test]
		public void CallAndConvertToType()
		{
			Json = @"
            {
                'user_id':221634238,
                'mutual': {
                    'count': 3,
                    'users': [227457746, 228907945, 229634083]
                },
				'message':'text'
            }";
			Url = "https://api.vk.com/method/friends.getRequests";
			var result = Api.Call<FriendsGetRequestsResult>("friends.getRequests", VkParameters.Empty);
			Assert.NotNull(result);
			Assert.That(result.UserId, Is.EqualTo(221634238));
			Assert.That(result.Message, Is.EqualTo("text"));
			Assert.That(result.Mutual.TotalCount, Is.EqualTo(3));
			Assert.IsNotEmpty(result.Mutual);
		}

		[Test]
		public void DefaultLanguageValue()
		{
			var lang = Api.GetLanguage();
			Assert.IsNull(lang);
		}

		[Test]
		public void EnglishLanguageValue()
		{
			Api.SetLanguage(Language.En);
			var lang = Api.GetLanguage();
			Assert.AreEqual(lang, Language.En);
		}
    }
}