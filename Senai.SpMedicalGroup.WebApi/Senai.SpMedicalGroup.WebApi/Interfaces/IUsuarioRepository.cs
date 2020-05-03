using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarUsuarios();
        Usuario BuscarUsuarioPorId(int id);

        void CadastrarUsuario(Usuario novoUsuario);

        void AtualizarUsuario(int id, Usuario usuarioAtualizado);

        void DeletarUsuario(int id);

        Usuario Login(string email, string senha);
    }
}
