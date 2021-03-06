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
    public class OgrencilerController : ControllerBase
    {
        readonly IOgrenciService _ogrenciServis;

        public OgrencilerController(IOgrenciService ogrenciServis)
        {
            _ogrenciServis = ogrenciServis;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ogrenciServis.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("ogrencikitapgetir")]
        public IActionResult OgrenciAdSoyadKitapGetir()
        {
            var result = _ogrenciServis.OgrenciAdSoyadKitapGetir();
            return result.Success ? Ok(result) : (IActionResult)BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Ogrenci ogrenci)
        {
            var result = _ogrenciServis.Add(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Ogrenci ogrenci)
        {
            var result = _ogrenciServis.Delete(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Ogrenci ogrenci)
        {
            var result = _ogrenciServis.Update(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("ogrencigetir")]
        public IActionResult OgrenciGetir(string text)
        {
            var result = _ogrenciServis.OgrenciGetir(text);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
