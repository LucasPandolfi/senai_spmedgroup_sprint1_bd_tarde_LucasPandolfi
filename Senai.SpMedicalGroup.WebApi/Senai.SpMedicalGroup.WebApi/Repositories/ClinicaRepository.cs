using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public void AtualizarClinica(int id, Clinica clinicaAtualizada)
        {
            Clinica ClinicaBuscada = ctx.Clinica.Find(id);

            if(ClinicaBuscada != null)
            {
                if (clinicaAtualizada.Endereco != null)
                {
                    ClinicaBuscada.Endereco = clinicaAtualizada.Endereco;
                }
                if(clinicaAtualizada.HorarioFuncionamento != null)
                {
                    ClinicaBuscada.HorarioFuncionamento = clinicaAtualizada.HorarioFuncionamento;
                }
                if(clinicaAtualizada.Cnpj != null)
                {
                    ClinicaBuscada.Cnpj = clinicaAtualizada.Cnpj;
                }
                if(clinicaAtualizada.RazaoSocial != null)
                {
                    ClinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
                }
            }           

            ctx.Clinica.Update(ClinicaBuscada);

            ctx.SaveChanges();
        }

        public void CadastrarClinica(Clinica novaClinica)
        {
            ctx.Clinica.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void DeletarClinica(int id)
        {
            Clinica ClinicaBuscada = ctx.Clinica.Find(id);

            ctx.Clinica.Remove(ClinicaBuscada);

            ctx.SaveChanges();
        }

        public List<Clinica> ListarClinicas()
        {
            return ctx.Clinica.ToList();
        }

        public Clinica ListarClinicasPorId(int id)
        {
            return ctx.Clinica.FirstOrDefault(cnc => cnc.IdClinica == id);
        }
    }
}
