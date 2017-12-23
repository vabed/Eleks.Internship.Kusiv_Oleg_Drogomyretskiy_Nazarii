﻿using System.Runtime.Serialization;
using VkNet.Utils;

namespace VkNet.Model
{
    using System;

    /// <summary>
    /// Город.
    /// </summary>
    /// <remarks>
    /// Страница документации ВКонтакте http://vk.com/dev/database.getCities
    /// </remarks>
    [Serializable]
    public class City
    {
        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Название города.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Район.
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// Область.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Является ли город основным.
        /// </summary>
        public bool Important { get; set; }

		#region Inernal Methods
		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static City FromJson(VkResponse response)
        {
			string id = response["comment_id"] ?? response["cid"] ?? response["id"];
	        return new City
			{
				Id = Convert.ToInt64(id),
				Title = response["title"] ?? response["name"],
				Area = response["area"],
				Region = response["region"],
				Important = response["important"] ?? false
			};
		}

        #endregion
    }
}