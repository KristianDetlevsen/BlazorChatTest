using System.Net.Http.Json;
using BlazorChatTest.Client.Pages.Components;

namespace BlazorChatTest.Client.Services
{
    public interface IChatService
    {
        public Task<Shared.ChatMessage[]> GetChatMessages();

        public Task PostChatMessage(Shared.ChatMessage message);
    }
}
