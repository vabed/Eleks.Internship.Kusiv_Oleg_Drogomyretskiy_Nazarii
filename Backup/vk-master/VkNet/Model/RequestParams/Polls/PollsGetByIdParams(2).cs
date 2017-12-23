﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Utils;

namespace VkNet.Model.RequestParams
{
    /// <summary>
    /// Список параметров для метода polls.getById
    /// </summary>
    public struct PollsGetByIdParams
    {
        /// <summary>
        /// Идентификатор владельца опроса.
        /// </summary>
        public long? OwnerId
        { get; set; }

        /// <summary>
        /// True — опрос находится в обсуждении, False — опрос прикреплен к стене.
        ///По умолчанию — False.
        /// </summary>
        public bool? IsBoard
        { get; set; }

        /// <summary>
        /// Идентификатор опроса.
        /// </summary>
        public long PollId
        { get; set; }

        /// <summary>
        /// Привести к типу VkParameters.
        /// </summary>
        /// <param name="p">Параметры.</param>
        /// <returns></returns>
        public static VkParameters ToVkParameters(PollsGetByIdParams p)
        {
            return new VkParameters
            {
                { "owner_id", p.OwnerId },
                { "is_board", p.IsBoard },
                { "poll_id", p.PollId },
            };
        }
    }
}
