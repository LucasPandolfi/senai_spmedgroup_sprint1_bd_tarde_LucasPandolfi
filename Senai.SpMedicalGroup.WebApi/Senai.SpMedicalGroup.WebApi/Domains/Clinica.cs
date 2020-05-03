using System;
using System.Collections.Generic;

namespace Senai.SpMedicalGroup.WebApi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Consulta = new HashSet<Consulta>();
            Medico = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public string Endereco { get; set; }
        public string HorarioFuncionamento { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public ICollection<Consulta> Consulta { get; set; }
        public ICollection<Medico> Medico { get; set; }
    }
}
