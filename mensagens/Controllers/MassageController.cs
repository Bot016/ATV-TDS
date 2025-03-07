using Microsoft.AspNetCore.Mvc;
using Bot.Models;
using System.Collections.Generic;
namespace Bot.Controllers
{
    public class MessageController : Controller
    {
        // Lista est�tica para armazenar as mensagens
        private static List<Message> messages = new List<Message>();
        [HttpGet]
        public IActionResult Index()
        {
            return View(messages);
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            // Adiciona a nova mensagem � lista
            messages.Add(message);
            // Passa a lista de mensagens para a view
            return View(messages);
        }
    }
}