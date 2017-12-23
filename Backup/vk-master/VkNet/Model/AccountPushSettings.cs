﻿using System;
using System.Collections.Generic;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	///
	/// </summary>
	public class AccountPushSettings
	{
		/// <summary>
		/// Отключены ли уведомления.
		/// </summary>
		public bool Disabled
		{ get; set; }

		/// <summary>
		/// Unixtime-значение времени, до которого временно отключены уведомления.
		/// </summary>
		public DateTime? DisabledUntil
		{ get; set; }

		/// <summary>
		/// Список, содержащий настройки конкретных диалогов, и их количество первым элементом.
		/// </summary>
		public IEnumerable<ChatPushSettings> Conversations
		{ get; set; }

		/// <summary>
		/// Объект с настройками Push-уведомлений в специальном формате.
		/// </summary>
		public PushSettings Settings
		{ get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static AccountPushSettings FromJson(VkResponse response)
		{
			return new AccountPushSettings
			{
				Disabled = response["disabled"],
				DisabledUntil = response["disabled_until"],
				Conversations = response["conversations"].ToReadOnlyCollectionOf<ChatPushSettings>(o => o),
				Settings = response["settings"]
			};
		}
	}
}