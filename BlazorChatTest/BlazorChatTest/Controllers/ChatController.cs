using Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BlazorChatTest.Client.Services;

namespace BlazorChatTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ChatService chatService;

        public ChatController(ChatService chatService)
        {
            this.chatService = chatService;
        }

        [HttpGet]
        public async Task<ActionResult<ChatMessage[]>> GetMessages()
        {
            var messages = await chatService.GetChatMessages();
            return Ok(messages);
        }

        [HttpPost]
        public async Task<ActionResult> PostMessage(ChatMessage message)
        {
            message.TimeStamp = DateTime.Now;
            await chatService.PostChatMessage(message);
            return Ok();
        }
    }
}
