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
    public class GymTimesController : ControllerBase
    {
        IGymTimeService _timeService;
        public GymTimesController(IGymTimeService timeService)
        {
            _timeService = timeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _timeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(GymTime gymTime)
        {
            var result = _timeService.Add(gymTime);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(GymTime gymTime)
        {
            var result = _timeService.Update(gymTime);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(GymTime gymTime)
        {
            var result = _timeService.Delete(gymTime);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
