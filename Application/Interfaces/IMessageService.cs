using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMessageService
    {
        Task SaveMessage(string chatId, string user, string content);
        Task<IEnumerable<Message>> GetMessages(string chatId);
    }
}
