﻿using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        //dependency injection
        // 1. definirati privatno svojstvo
        private readonly EdunovaContext _context;
        //dependency injection
        // 2. proslijedis instancu kroz konstruktor
        public SmjerController(EdunovaContext context) 
        {
        
            _context = context;
        
        }

        [HttpGet]
        public IActionResult Get() 
        {

            return Ok(_context.Smjerovi);
        
        }
        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {

            return Ok(_context.Smjerovi.Find(sifra));

        }

        [HttpPost]
        public IActionResult Post(Smjer smjer) 
        {

            _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, Smjer smjer) 
        {
        
            var smjerBaza = _context.Smjerovi.Find(sifra);

            //za sada rucno kasnije mapper
            smjerBaza.Naziv = smjer.Naziv;
            smjerBaza.Tranjanje = smjer.Tranjanje;
            smjerBaza.Cijena = smjer.Cijena;
            smjerBaza.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerBaza.Vaucer = smjer.Vaucer;

            _context.Smjerovi.Update(smjerBaza);
            _context.SaveChanges();

             
            return Ok(new { poruka = "Uspjesno promjenjeno" });
        }

        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int sifra)
        {

            var smjerBaza = _context.Smjerovi.Find(sifra);

            _context.Smjerovi.Update(smjerBaza);
            _context.SaveChanges();


            return Ok(new { poruka = "Uspjesno obrisano" });
        }
    }
}
