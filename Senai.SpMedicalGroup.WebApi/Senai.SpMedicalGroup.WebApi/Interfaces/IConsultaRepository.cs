using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> ListarConsultas();

        Consulta ListarConsultaPorId(int id);

        void CadastrarConsulta(Consulta novaConsulta);

        void AtualizarConsulta(int id, Consulta consultaAtualizada);

        void DeletarConsulta(int id);

        List<Consulta> ListarMinhasConsultas(int id);
    }
}
