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
    public class KitaplarController : ControllerBase
    {
        readonly IKitapService _kitapService;

        public KitaplarController(IKitapService kitapService)
        {
            _kitapService = kitapService;
        }
        
        [HttpPost("add")]
        public IActionResult Add(Kitap kitap)
        {
            var result = _kitapService.Add(kitap);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("delete")]
        public IActionResult Delete(Kitap kitap)
        {
            var result = _kitapService.Delete(kitap);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("update")]
        public IActionResult Update(Kitap kitap)
        {
            var result = _kitapService.Update(kitap);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("kitapyazarturgetir")]
        public IActionResult KitapYazarTurGetir()
        {
            var result = _kitapService.KitapYazarTurGetir();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kitapService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _kitapService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
