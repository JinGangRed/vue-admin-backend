using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Admin.Controllers
{
    [Route("api/[controller]")]
    public class MenuController : BaseController
    {
        public MenuController(IRepositoryWrapper wrapper) : base(wrapper)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menus = wrapper.MenuRepository.FindAll();
            return Json(menus);
        }

    }
}
