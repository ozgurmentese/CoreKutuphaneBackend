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
    public class YazarlarController : ControllerBase
    {
        readonly IYazarService _yazarService;

        public YazarlarController(IYazarService yazarService)
        {
            _yazarService = yazarService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yazarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _yazarService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Yazar yazar)
        {
            var result = _yazarService.Add(yazar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Yazar yazar)
        {
            var result = _yazarService.Delete(yazar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Yazar yazar)
        {
            var result = _yazarService.Update(yazar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("yazaragoregetir")]
        public IActionResult YazaraGoreGetir(int id)
        {
            var result = _yazarService.YazaraGoreGetir2(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
