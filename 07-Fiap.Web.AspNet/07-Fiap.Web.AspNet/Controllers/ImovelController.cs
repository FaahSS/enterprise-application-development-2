using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class ImovelController : Controller
    {
        private BancoContext _context;
        public ImovelController(BancoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Imovel imovel)
        {
            return
        }

    }
}