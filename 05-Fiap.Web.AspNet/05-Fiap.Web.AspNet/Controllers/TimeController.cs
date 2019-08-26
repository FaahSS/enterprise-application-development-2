using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class TimeController : Controller
    {
        private static IList<Time> _banco = new List<Time>();
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
        public IActionResult Cadastrar(Time time)
        {
            _banco.Add(time);

            ViewBag.nome = time.Nome;
            ViewBag.classif = time.Classificado;
            return View();
        }

        public IActionResult Listar()
        {
            TempData["msg"] = "Time cadastrado com sucesso!";
            return View(_banco);
        }
    }
}