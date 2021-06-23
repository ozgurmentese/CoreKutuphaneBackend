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
    public class IslemlerController : ControllerBase
    {
        readonly IIslemService _islemService;

        public IslemlerController(IIslemService islemService)
        {
            _islemService = islemService;
        }

        [HttpGet("kutuphanedekikitaplar")]
        public IActionResult KutuphanedekiKitaplar()
        {
            var result = _islemService.KutuphanedekiKitaplar();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("kutuphanedeolankitaplar")]
        public IActionResult KutuphanedeOlanKitaplar()
        {
            var result = _islemService.KutuphanedeOlanKitaplar();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("kutuphanedeolmayankitaplar")]
        public IActionResult KutuphanedeOlmayanKitaplar()
        {
            var result = _islemService.KutuphanedeOlmayanKitaplar();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Islem islem)
        {
            var result = _islemService.Add(islem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("tutarbelirle")]
        public IActionResult TutarBelirle(int id)
        {
            var result = _islemService.TutarBelirle(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
