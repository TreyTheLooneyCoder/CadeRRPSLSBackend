using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeRRPSLSProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadeRRPSLSProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RPSLSServices _rPSLSServices;
        public RPSLSController(RPSLSServices rPSLSServices)
        {
            _rPSLSServices = rPSLSServices;
        }

        [HttpGet]
        [Route("RPS")]

        public string lizardSpock()
        {
            return _rPSLSServices.lizardSpock();
        }
    }
}