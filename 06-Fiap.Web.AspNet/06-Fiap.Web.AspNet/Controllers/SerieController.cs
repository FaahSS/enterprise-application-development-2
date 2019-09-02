using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {
        //Tipo o "em", vai acessar as coisas no banco
        private BancoContext _context;
        //O contexto será instanciado pelo framework
        public SerieController(BancoContext context)
        {
            _context = context;
        }

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
            TempData["msg"] = "Série cadastrada com sucesso!";
            return RedirectToAction("Listar");
        }
        public IActionResult Listar()
        {
            return View(_banco);
        }
    }
}