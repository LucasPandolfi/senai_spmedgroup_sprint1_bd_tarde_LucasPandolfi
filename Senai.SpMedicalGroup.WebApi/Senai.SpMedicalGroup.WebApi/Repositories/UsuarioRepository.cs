using Microsoft.EntityFrameworkCore;
using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public void AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if (usuarioBuscado != null)
            {
                if(usuarioAtualizado.Email!= null)
                {
                    usuarioBuscado.Email = usuarioAtualizado.Email;
                }
                if(usuarioAtualizado.Senha != null)
                {
                    usuarioBuscado.Senha = usuarioAtualizado.Senha;
                }
                if(usuarioAtualizado.IdTipoUsuario != null)
                {
                    usuarioBuscado.IdTipoUsuario = usuarioAtualizado.IdTipoUsuario;
                }

                ctx.Usuario.Update(usuarioBuscado);

                ctx.SaveChanges();
            }
        }

        public void CadastrarUsuario(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            ctx.Usuario.Remove(usuarioBuscado);

            ctx.SaveChanges();

        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(us => us.IdUsuario == id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return ctx.Usuario.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            Usuario usuarioBuscado = ctx.Usuario

                .Include(u => u.IdTipoUsuarioNavigation)
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuarioBuscado != null)
            {
                return usuarioBuscado;
            }

            return null;
        }
    }
}
