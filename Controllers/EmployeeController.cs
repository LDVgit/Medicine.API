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

        [HttpGet("GetEmployees")]
        public ActionResult GetEmployeers()
        {
            return Ok(_src.GetAll());
        }
        /// <summary>
        /// Создание работника
        /// </summary>
        /// <param name="employee"> Работник </param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post(Employee employee)
        {
            _src.ActionEmployee += GetFirstName; //Пример использования события
            _src.CreateEmployee(employee);
            return Ok(employee);
        }


        [HttpDelete("RemoveEmployee/{id}")]
        public ActionResult RemoveEmployee(int id)
        {
            _src.RemoveEmployee(id);
            return Ok();
        }

        [HttpPut("UpdateEmployee")]
        public ActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _src.UpdateEmployee(employee);
            return Ok(employee);
        }
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="message"> Сообщение в консоль </param>
        private void GetFirstName(string message)
        {
            Console.WriteLine(message);
        }
    }
}