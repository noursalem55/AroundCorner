﻿using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        [ApiExplorerSettings(IgnoreApi =true)]
        public IActionResult Error (int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }


    }
}
