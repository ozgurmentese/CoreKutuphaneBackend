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
    public class TurlerController : ControllerBase
    {
        readonly ITurService _turService;

        public TurlerController(ITurService turService)
        {
            _turService = turService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _turService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _turService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Tur tur)
        {
            var result = _turService.Add(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("delete")]
        public IActionResult Delete(Tur tur)
        {
            var result = _turService.Delete(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
                
        [HttpPost("update")]
        public IActionResult Update(Tur tur)
        {
            var result = _turService.Update(tur);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("turegoregetir")]
        public IActionResult TureGoreGetir(int id)
        {
            var result = _turService.TureGoreGetir2(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
