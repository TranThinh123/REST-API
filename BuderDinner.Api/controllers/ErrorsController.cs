using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuderDinner.Api.controllers
{
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {

           Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>().Error;

            return Problem(title: exception?.Message, statusCode: 400);
        }
    }
}