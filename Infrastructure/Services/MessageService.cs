using Application.Interfaces;
using Domain.Models;
using Infrastructure.data;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MessageService : IMessageService
    {
        private readonly MessengerContext _db;
        public MessageService(MessengerContext db)
        {
            _db = db;
        }
        public Task<IEnumerable<Message>> GetMessages(string chatId)
        {
            throw new NotImplementedException();
        }

        public Task SaveMessage(string chatId, string user, string content)
        {
            var userInDb=_db.Users.FirstOrDefault(x => x.Username == user);
            var message = new Message()
            {
                ChatId = Convert.ToInt32(chatId),
                Content = content,
                Sender = userInDb,
                Timestamp = DateTime.Now
            };
            _db.Messages.AddAsync(message)


        }




    }
}
