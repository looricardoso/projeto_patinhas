using System;
using System.Collections.Generic;

namespace projeto_patinhas.bd
{
    public partial class TbUsuario
    {
        public int CdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string SobrenomeUsuario { get; set; }
        public DateTime DtNascimento { get; set; }
        public string CepEndereco { get; set; }
        public string NmEndereco { get; set; }
        public int NrEndereco { get; set; }
        public string NmBairro { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string NrSenha { get; set; }
        public int IdDog { get; set; }

        public virtual TbDog IdDogNavigation { get; set; }
    }
}
