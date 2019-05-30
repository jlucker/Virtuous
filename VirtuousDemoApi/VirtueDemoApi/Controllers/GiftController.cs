using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtueDemoApi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VirtueDemoApi.Controllers
{
    [Route("api/gift")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            string jsonString;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                jsonString = reader.ReadToEnd();
            }

            var gifts = JsonConvert.DeserializeObject<Gifts>(jsonString);

            Ask ask = new Ask(500.75, "single");
            
            return Ok(ask);
        }
    }
}
