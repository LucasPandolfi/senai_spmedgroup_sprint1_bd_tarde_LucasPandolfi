using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTipoUsuario();

        TipoUsuario BuscarTipoUsuarioPorId(int id);

        void CadastrarTipoUsuario(TipoUsuario NovoTipoUsuario);

        void AtualizarTipoUsuario(int id, TipoUsuario tipoUsuarioAtualizado);

        void DeletarTipoUsuario(int id);
    }
}
