using Microsoft.AspNetCore.Mvc;

namespace RightSupplier.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        // POST: api/request
        [HttpPost]
        public IActionResult SubmitRequest([FromBody] SupplierRequest request)
        {
            if (request == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Logic to handle the supplier request.

            return Ok(new { message = "Request submitted successfully!" });
        }
    }
}

public class SupplierRequest
{
    public string SupplierName { get; set; }
    public string RequestDetails { get; set; }
}