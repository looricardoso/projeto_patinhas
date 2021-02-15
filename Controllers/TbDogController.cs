using Microsoft.AspNetCore.Mvc;
using projeto_patinhas.bd;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace projeto_patinhas.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TbDogController : ControllerBase
    {
        private bd_patinhasContext _tbDogs { get; set; }
        public TbDogController(bd_patinhasContext contexto)
        {
            _tbDogs = contexto;
        }

        [HttpGet]
        public DbSet<TbDog> Get()
        {
            var listaDogs = _tbDogs.TbDog;

            return listaDogs;
        }
    }
}