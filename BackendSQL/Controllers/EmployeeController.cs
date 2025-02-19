using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace BackendSQL.Controllers
{
    [Route("api/employee")] // my url suffix
    [ApiController] // Enables built in Api behavior
    public class EmployeeController : ControllerBase // provides the neccessary built in methods for controller | Ok() | NotFound() | BadRequest() | CreatedAtAction() 
    {
    }
}
