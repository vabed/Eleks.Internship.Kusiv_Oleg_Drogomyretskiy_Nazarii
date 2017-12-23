﻿using VkNet.Model.Attachments;

namespace VkNet.Model
{
    using VkNet.Utils;

    /// <summary>
    /// Информация о статусе пользователя.
    /// См. описание http://vk.com/dev/status.get
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Текст статуса.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Информация об играющей в текущей момент у пользователя аудиокомпозиции.
        /// </summary>
        public Audio Audio { get; set; }

		#region Методы
		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static Status FromJson(VkResponse response)
		{
			var status = new Status
			{
				Text = response["text"],
				Audio = response["audio"]
			};

			return status;
		}

		#endregion
	}
}