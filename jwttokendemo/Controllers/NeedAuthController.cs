﻿using jwttokendemo.Filters;
using jwttokendemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace jwttokendemo.Controllers
{
    [JwtAuth]
    public class NeedAuthController : ApiController
    {
        [HttpGet]
        public APIResult Get()
        {
            var fooUser = Request.Properties["user"] as string;

            return new APIResult()
            {
                Success = true,
                Message = $"授權使用者為 {fooUser}",
                Payload = new string[] { "有提供存取權杖1", "有提供存取權杖2" }
            };
        }
    }
}