using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicine.API.Models;

namespace Medicine.API.Services
{
    public class EmployeeService
    {
        private readonly ApiContext _ctx;

        public EmployeeService(ApiContext ctx)
        {
            _ctx = ctx;
        }


    }
}
