using System;
using System.Collections.Generic;

namespace projeto_patinhas.bd
{
    public partial class TbDog
    {
        public TbDog()
        {
            TbUsuario = new HashSet<TbUsuario>();
        }

        public int CdDog { get; set; }
        public string NmDog { get; set; }
        public int IdRaca { get; set; }
        public int QtIdade { get; set; }
        public bool StVermifugado { get; set; }
        public bool StCastrado { get; set; }
        public bool Vacinado { get; set; }
        public string DsTemperamento { get; set; }
        public string ObsDog { get; set; }

        public virtual TbRacasDog IdRacaNavigation { get; set; }
        public virtual ICollection<TbUsuario> TbUsuario { get; set; }
    }
}
