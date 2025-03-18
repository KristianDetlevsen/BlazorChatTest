using System.Collections.Generic;
using System.Net.Http;
using BlazorChatTest.Client.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shared;

namespace BlazorChatTest.Services
{
    public class ChatService : IChatService
    {
        public async Task<Shared.ChatMessage[]> GetChatMessages()
        {
            List<ChatMessage> messages = [];
            messages.Add(new ChatMessage { Message = "Hej", Name = "Bob", TimeStamp=DateTime.Now});
            messages.Add(new ChatMessage { Message = "Hej", Name = "Bob", TimeStamp = DateTime.Now });
            messages.Add(new ChatMessage { Message = "Hej", Name = "Bob", TimeStamp = DateTime.Now });
            messages.Add(new ChatMessage { Message = "Hej", Name = "Bob", TimeStamp = DateTime.Now });
            messages.Add(new ChatMessage { Message = "Hej", Name = "Bob", TimeStamp = DateTime.Now });
            return messages.ToArray();
        }
    }
}
