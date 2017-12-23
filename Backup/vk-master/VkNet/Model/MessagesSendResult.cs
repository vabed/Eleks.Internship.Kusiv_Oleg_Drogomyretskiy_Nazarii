﻿using System.Collections.ObjectModel;
using VkNet.Model.Attachments;
using VkNet.Utils;

namespace VkNet.Model
{
    public class MessagesSendResult
    {
        /// <summary>
        /// Идентификатор назначения;
        /// </summary>
        public int? PeerId { get; set; }
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        public int? MessageId { get; set; }
        /// <summary>
        /// Cообщение об ошибке, если сообщение не было доставлено получателю. 
        /// </summary>
        public string Error { get; set; }
        
        /// <summary>
        /// Разобрать из json.
        /// </summary>
        /// <param name="response">Ответ сервера.</param>
        /// <returns></returns>
        public static MessagesSendResult FromJson(VkResponse response)
        {
            return new MessagesSendResult
            {
                PeerId = response["peer_id"],
                MessageId = response["message_id"],
                Error = response["error"]
            };
        }
    }
}