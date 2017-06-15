using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace messageBoardBackEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        static List<Models.Message> messages = new List<Models.Message> {

            new Models.Message{
                        Owner = "John",
                        Text = "hello"
                    },

                    new Models.Message{
                        Owner = "Tim",
                        Text = "Hi"
                    }

        };
        public IEnumerable<Models.Message> Get()
        {
            return messages;
            
        }
        [HttpPost]
        public Models.Message Post([FromBody] Models.Message message)
        {
            messages.Add(message);
            return message;

        }
    }
}