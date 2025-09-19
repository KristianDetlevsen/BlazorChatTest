using System.Net.Http.Json;
using BlazorChatTest.Client.Pages.Components;
using Shared;
using static System.Net.WebRequestMethods;

namespace BlazorChatTest.Client.Services
{
    public class ChatService : IChatService
    {
        private readonly HttpClient _httpClient;

        public ChatService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Shared.ChatMessage[]> GetChatMessages()
        {
            return await _httpClient.GetFromJsonAsync<Shared.ChatMessage[]>("api/chat");
        }

        public async Task PostChatMessage(Shared.ChatMessage message)
        {
            await _httpClient.PostAsJsonAsync("api/chat", message);
        }
    }
}
