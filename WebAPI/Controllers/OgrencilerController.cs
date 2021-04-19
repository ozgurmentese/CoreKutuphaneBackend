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
        IOgrenciServis _ogrenciServis;

        public OgrencilerController(IOgrenciServis ogrenciServis)
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

        public IActionResult Add(Ogrenci ogrenci)
        {
            var result = _ogrenciServis.Add(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
