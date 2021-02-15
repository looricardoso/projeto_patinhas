using System;
using System.Collections.Generic;

namespace projeto_patinhas.bd
{
    public partial class TbRacasDog
    {
        public TbRacasDog()
        {
            TbDog = new HashSet<TbDog>();
        }

        public int CdRaca { get; set; }
        public string NmRaca { get; set; }
        public string Porte { get; set; }

        public virtual ICollection<TbDog> TbDog { get; set; }
    }
}
