using System;
using API.DTOs;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
   [HttpGet("unauthorized")]
   public IActionResult GetUnauthorized()
   {
    return Unauthorized();
   }

   [HttpGet("badrequest")]
   public IActionResult GetBadRequest()
   {
    return BadRequest("Not good Request");
   }
   
   [HttpGet("notfound")]
   public IActionResult GetNotFound()
   {
    return NotFound("Not Found");
   }


   [HttpGet("internal error")]
   public IActionResult GetInternalError()
   {
    throw new Exception("this is a test Exception");
   }

   [HttpPost("validationerror")]
   public IActionResult GetValidationError(CreateProductDto product)
   {
    return Ok();
   }
}
