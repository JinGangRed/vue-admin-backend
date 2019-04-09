using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Admin.Controllers
{
    public class BaseController : Controller
    {
        protected IRepositoryWrapper wrapper;
        public BaseController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }
    }
}
