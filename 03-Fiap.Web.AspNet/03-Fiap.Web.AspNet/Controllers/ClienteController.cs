using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página do formulário
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost] //Cadastrar no clique do botão
        public IActionResult Cadastrar(Cliente cliente)
        {
            ViewData["nome"] = cliente.Nome;
            ViewBag.cpf = cliente.Cpf;
            TempData["msg"] = "Usuário cadastrado";
            return View();
            // return Content(cliente.Nome + " " + cliente.Cpf);
        }
    }
}