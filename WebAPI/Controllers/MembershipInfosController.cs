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
    public class MembershipInfosController : ControllerBase
    {
        IMembershipInfoService _membershipInfoService;
        public MembershipInfosController(IMembershipInfoService membershipInfoService)
        {
            _membershipInfoService = membershipInfoService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _membershipInfoService.GetAll();
            if (result.Success)
            {
                return Ok(result);      
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(MembershipInfo membershipInfo)
        {
            var result = _membershipInfoService.Add(membershipInfo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(MembershipInfo membershipInfo)
        {
            var result = _membershipInfoService.Update(membershipInfo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(MembershipInfo membershipInfo)
        {
            var result = _membershipInfoService.Delete(membershipInfo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
