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
    public class MembersController : ControllerBase
    {
        IMemberService _memberService;
        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _memberService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
            var result = _memberService.GetMemberDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyage")]
        public IActionResult GetByAge(int minAge)
        {
            var result = _memberService.GetByAge(minAge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbygender")]
        public IActionResult GetByGender(string gender)
        {
            var result = _memberService.GetByGender(gender);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyweight")]
        public IActionResult GetByWeight(float minWeight, float maxWeight)
        {
            var result = _memberService.GetByWeight(minWeight,maxWeight);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyheight")]
        public IActionResult GetByHeight(float minHeight, float maxHeight)
        {
            var result = _memberService.GetByHeight(minHeight, maxHeight);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbymembership")]
        public IActionResult GetByMembership(int membershipTimeId)
        {
            var result = _memberService.GetByMembership(membershipTimeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbygymtime")]
        public IActionResult GetByGymTime(int gymTimeId)
        {
            var result = _memberService.GetByGymTime(gymTimeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyfee")]
        public IActionResult GetByFee(float minFee, float maxFee)
        {
            var result = _memberService.GetByFee(minFee, maxFee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Member member)
        {
            var result = _memberService.Add(member);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Member member)
        {
            var result = _memberService.Delete(member);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Member member)
        {
            var result = _memberService.Update(member);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
