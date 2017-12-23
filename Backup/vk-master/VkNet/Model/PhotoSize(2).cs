﻿using System;
using System.Runtime.Serialization;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Формат описания размеров фотографи.
	/// </summary>
	[Serializable]
	public class PhotoSize
	{
		/// <summary>
		/// Uri копии изображения.
		/// </summary>
		public Uri Src
		{ get; set; }

		/// <summary>
		/// Ширина копии в пикселах.
		/// </summary>
		public ulong Width
		{ get; set; }

		/// <summary>
		/// Высота копии в пикселах.
		/// </summary>
		public ulong Height
		{ get; set; }

		/// <summary>
		/// Обозначение размера и пропорций копии.
		/// </summary>
		public PhotoSizeType Type
		{ get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		public static PhotoSize FromJson(VkResponse response)
		{
			var giftItem = new PhotoSize
			{
				Src = new Uri(response["src"]),
				Width = response["width"],
				Height = response["height"],
				Type = response["type"]
			};

			return giftItem;
		}
	}
}
