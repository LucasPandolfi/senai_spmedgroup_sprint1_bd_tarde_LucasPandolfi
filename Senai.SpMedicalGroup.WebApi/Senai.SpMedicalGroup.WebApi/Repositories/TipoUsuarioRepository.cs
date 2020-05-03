using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public List<TipoUsuario> ListarTipoUsuario()
        {
            return ctx.TipoUsuario.ToList();
        }

        public TipoUsuario BuscarTipoUsuarioPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(TU => TU.IdTipoUsuario == id);
        }

        public void CadastrarTipoUsuario (TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuario.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void AtualizarTipoUsuario(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario TipoUsuarioBuscado = ctx.TipoUsuario.Find(id);

            if(TipoUsuarioBuscado != null)
            {
                if(tipoUsuarioAtualizado.Nome != null)
                {
                    TipoUsuarioBuscado.Nome = tipoUsuarioAtualizado.Nome;
                }
            }
  
            ctx.TipoUsuario.Update(TipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public void DeletarTipoUsuario(int id)
        {
            TipoUsuario TipoUsuarioBuscado = ctx.TipoUsuario.Find(id);

            ctx.TipoUsuario.Remove(TipoUsuarioBuscado);

            ctx.SaveChanges();
        }
    }
}
