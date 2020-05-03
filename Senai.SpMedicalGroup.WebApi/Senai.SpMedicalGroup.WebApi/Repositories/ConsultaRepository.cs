using Senai.SpMedicalGroup.WebApi.Domains;
using Senai.SpMedicalGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SpMedicalGroupContext ctx = new SpMedicalGroupContext();

        public void AtualizarConsulta(int id, Consulta consultaAtualizada)
        {
            Consulta ConsultaBuscada = ctx.Consulta.Find(id);

            if (ConsultaBuscada != null)
            {
                if (consultaAtualizada.DataConsulta != null)
                {
                    ConsultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;
                }
                if (consultaAtualizada.DescricaoConsulta != null)
                {
                    ConsultaBuscada.DescricaoConsulta = consultaAtualizada.DescricaoConsulta;
                }
                if (consultaAtualizada.IdSituacao != null)
                {
                    ConsultaBuscada.IdSituacao = consultaAtualizada.IdSituacao;
                }
                if (consultaAtualizada.IdClinica != null)
                {
                    ConsultaBuscada.IdClinica = consultaAtualizada.IdClinica;
                }
                if (consultaAtualizada.IdMedico != null)
                {
                    ConsultaBuscada.IdMedico = consultaAtualizada.IdMedico;
                }
                if (consultaAtualizada.IdProntuario != null)
                {
                    ConsultaBuscada.IdProntuario = consultaAtualizada.IdProntuario;
                }
            }

            ctx.Consulta.Update(ConsultaBuscada);

            ctx.SaveChanges();
        }

        public void CadastrarConsulta(Consulta novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void DeletarConsulta(int id)
        {
            Consulta ConsultaBuscada = ctx.Consulta.Find(id);

            ctx.Consulta.Remove(ConsultaBuscada);

            ctx.SaveChanges();
        }

        public Consulta ListarConsultaPorId(int id)
        {
            return ctx.Consulta.FirstOrDefault(C => C.IdConsulta == id);
        }

        public List<Consulta> ListarConsultas()
        {
            return ctx.Consulta.ToList();
        }

        public List<Consulta> ListarMinhasConsultas(int id)
        {
            return ctx.Consulta.ToList().FindAll(C => C.IdProntuario == id);
        }
    }
}
