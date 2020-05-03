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
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
       

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.ListarUsuarios());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_usuarioRepository.BuscarUsuarioPorId(id));
        }


        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            _usuarioRepository.CadastrarUsuario(novoUsuario);

            return StatusCode(201);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            // Faz a chamada para o método
            _usuarioRepository.AtualizarUsuario(id, usuarioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _usuarioRepository.DeletarUsuario(id);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}