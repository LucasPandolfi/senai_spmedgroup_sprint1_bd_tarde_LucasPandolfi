using Senai.SpMedicalGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> ListarClinicas();

        Clinica ListarClinicasPorId(int id);

        void CadastrarClinica(Clinica novaClinica);

        void AtualizarClinica(int id, Clinica clinicaAtualizada);

        void DeletarClinica(int id);
    }
}
