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
    public class ConsultaController : ControllerBase
    {
        IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_consultaRepository.ListarConsultas());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_consultaRepository.ListarConsultaPorId(id));
        }

        [HttpGet("Prontuario/{id}")]
        public IActionResult GetUmProntuario(int id)
        {
            return Ok(_consultaRepository.ListarMinhasConsultas(id));
        }

        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            _consultaRepository.CadastrarConsulta(novaConsulta);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Consulta consultaAtualizada)
        {
            _consultaRepository.AtualizarConsulta(id, consultaAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _consultaRepository.DeletarConsulta(id);

            return StatusCode(204);
        }
    }
}