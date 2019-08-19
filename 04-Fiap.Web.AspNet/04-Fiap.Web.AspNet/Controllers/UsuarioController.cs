using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {
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
        public IActionResult Cadastrar(Usuario usuario)
        {
            ViewData["nome"] = usuario.Nome;
            ViewBag.dataN = usuario.DataNascimento;
            ViewBag.email = usuario.Email;
            TempData["msg"] = "Usuário Cadastrado";
            //Retorna o objeto para view
            return View(usuario);
        }


    }
}