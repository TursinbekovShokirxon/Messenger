using Application.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Messenger.Hubs
{
    public class ChatHub:Hub
    {
        private readonly IMessageService _messageService;
        public ChatHub(IMessageService messageService)
        {
            _messageService = messageService;
        }


    }
}
