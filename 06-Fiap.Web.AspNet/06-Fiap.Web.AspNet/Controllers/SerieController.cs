using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {
        private static IList<Serie> _banco = new List<Serie>();
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
        public IActionResult Cadastrar(Serie serie)
        {
            _banco.Add(serie);
            ViewBag.nome = serie.Nome;
            ViewBag.gen = serie.Genero;
            return RedirectToAction("Listar");
        }
        public IActionResult Listar()
        {
            TempData["msg"] = "Série cadastrada com sucesso!";
            return View(_banco);
        }
    }
}