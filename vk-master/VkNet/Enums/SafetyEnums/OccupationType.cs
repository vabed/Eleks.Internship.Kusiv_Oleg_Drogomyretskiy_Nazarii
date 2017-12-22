﻿using System;
using System.Runtime.Serialization;

namespace VkNet.Enums.SafetyEnums
{
	/// <summary>
	/// Информация о текущем роде занятия пользователя.
	/// </summary>
	[Serializable]
	public sealed class OccupationType : SafetyEnum<OccupationType>
	{
		/// <summary>
		/// Работа.
		/// </summary>
		public static readonly OccupationType Work = RegisterPossibleValue("work");

		/// <summary>
		/// Школа.
		/// </summary>
		public static readonly OccupationType School = RegisterPossibleValue("school");

		/// <summary>
		/// ВУЗ.
		/// </summary>
		public static readonly OccupationType University = RegisterPossibleValue("university");
	}
}