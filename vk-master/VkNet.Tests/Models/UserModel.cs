﻿using NUnit.Framework;
using VkNet.Model;

namespace VkNet.Tests.Models
{
    [TestFixture]
    public class UserModel : BaseTest
    {
        [Test]
        public void ShouldHaveField_Trending()
        {
            var user = new User();
            Assert.That(user, Has.Property("Trending"));
        }
        
        [Test]
        public void Trending_ShouldBeTrue()
        {
            Json = "{'trending':1}";
            var response = GetResponse();
            var user = User.FromJson(response);
            Assert.That(user.Trending, Is.True);
        }
        
        [Test]
        public void Trending_ShouldBeFalse()
        {
            Json = "{'trending':0}";
            var response = GetResponse();
            var user = User.FromJson(response);
            Assert.That(user.Trending, Is.False);
        }
        
        [Test]
        public void Trending_ShouldBeFalse2()
        {
            Json = "{}";
            var response = GetResponse();
            var user = User.FromJson(response);
            Assert.That(user.Trending, Is.False);
        }
        
        [Test(Description = "Поле 'name' может иметь одно слово")]
        public void Name_ShouldCanBeOneWord()
        {
            Json = "{'name': 'бот'}";
            var response = GetResponse();
            var user = User.FromJson(response);
            Assert.That(user.FirstName, Is.EqualTo("бот"));
            Assert.That(user.LastName, Is.Null);
        }
    }
}