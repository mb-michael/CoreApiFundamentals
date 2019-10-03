using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    //ControllerBase is specialized for APIs
    public class CampsController : ControllerBase
    {
        //route + action = endpoint
        [HttpGet]
        public IActionResult GetCamps()
        {
            //successful response
            return Ok(new { Moniker = "ATL2018", Name = "Atlanta Code Camp" });
        }
    }
}