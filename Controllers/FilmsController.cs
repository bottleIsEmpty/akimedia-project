using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace akimedia_project.Controllers
{
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        [HttpGet("[action]/{id}")]
        public int Get(int id) {
            return id;
        }

        [HttpGet("[action]/")]
        public int[] Get() {
            return new int[] {1, 2, 3, 4, 5};
        }

    }
}
