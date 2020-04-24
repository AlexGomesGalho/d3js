using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstStateLessAPIService.Models;

namespace FirstStateLessAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : Controller
    {
      [HttpGet]
      [Route("get")]
      public async Task Get()
        {
           await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
