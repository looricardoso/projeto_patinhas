using Microsoft.AspNetCore.Mvc;
using projeto_patinhas.bd;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace projeto_patinhas.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TbRacasDogController : ControllerBase
    {
        private bd_patinhasContext _tbRacas { get; set; }
        public TbRacasDogController(bd_patinhasContext contexto)
        {
            _tbRacas = contexto;
        }

        [HttpGet]
        public DbSet<TbRacasDog> Get()
        {
            var listaRacas = _tbRacas.TbRacasDog;

            return listaRacas;
        }
    }
}