using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using Senai.SpMedicalGroup.WebApi.Repositories;

namespace Senai.SpMedicalGroup.WebApi.Controllers
{
    [Produces("application/Json")]

    [Route("api/[controller]")]

    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository;

        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clinicaRepository.ListarClinicas());
        }

        [HttpGet ("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_clinicaRepository.ListarClinicasPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Clinica novaClinica)
        {
            _clinicaRepository.CadastrarClinica(novaClinica);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Clinica clinicaAtualizada)
        {
            _clinicaRepository.AtualizarClinica(id, clinicaAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clinicaRepository.DeletarClinica(id);

            return StatusCode(204);
        }
    }
}