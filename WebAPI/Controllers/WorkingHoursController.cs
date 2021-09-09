using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHoursController : ControllerBase
    {
        IWorkingHourService _workingService;
        public WorkingHoursController(IWorkingHourService workingService)
        {
            _workingService = workingService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _workingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(WorkingHour workingHour)
        {
            var result = _workingService.Add(workingHour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(WorkingHour workingHour)
        {
            var result = _workingService.Update(workingHour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(WorkingHour workingHour)
        {
            var result = _workingService.Delete(workingHour);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
