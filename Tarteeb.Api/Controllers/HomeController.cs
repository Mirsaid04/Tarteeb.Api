﻿using Microsoft.AspNetCore.Mvc;

namespace Tarteeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet]

        public ActionResult<string> GetHomeMessage() => "Tarteeb is running...";
    }
}
