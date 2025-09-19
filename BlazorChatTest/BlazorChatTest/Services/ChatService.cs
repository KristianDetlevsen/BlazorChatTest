using System.Collections.Generic;
using System.Net.Http;
using BlazorChatTest.Client.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shared;

namespace BlazorChatTest.Services
{
    public class ChatService : IChatService
    {
        private readonly List<Shared.ChatMessage> messages = [];
        
        public async Task<Shared.ChatMessage[]> GetChatMessages()
        {
            return await Task.FromResult(messages.ToArray());
        }

        public Task PostChatMessage(ChatMessage message)
        {
            messages.Add(message);
            return Task.CompletedTask;
        }
    }
}
