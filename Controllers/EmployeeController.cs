using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicine.API.Services;
using Medicine.API.Models;

namespace Medicine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _src;
        public EmployeeController(IEmployee src)
        {
            _src = src;
        }

        [HttpGet("GetEmployeers")]
        public ActionResult GetEmployeers()
        {
            return Ok(_src.GetAll());
        }

        [HttpPost]
        public ActionResult Post(Employee employee)
        {
            _src.CreateEmployee(employee);
            return Ok(employee);
        }

    }
}
