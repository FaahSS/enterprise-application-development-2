using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Persistences;
using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        //private static IList<Serie> _banco = new List<Serie>();
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
            _context.Series.Add(serie);
            _context.SaveChanges();
            ViewBag.nome = serie.Nome;
            ViewBag.gen = serie.Genero;
            TempData["msg"] = "Série cadastrada com sucesso!";
            return RedirectToAction("Listar");
        }
        public IActionResult Listar()
        {
            return View(_context.Series.ToList());
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar a serie no banco de dados
            var serie = _context.Series.Find(id);
            //Retornar a view com a serie que será atualizada
            return View(serie);
        }
        [HttpPost]
        public IActionResult Editar(Serie serie)
        {
            //atualiza no banco
            _context.Attach(serie).State = EntityState.Modified;
            _context.SaveChanges();
            //mensagem de sucesso para a tela
            TempData["msg"] = "Atualizado!";
            //redirect para o método de listagem
            return RedirectToAction("Listar");

        }
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var serie = _context.Series.Find(id); //Pesquisa
            _context.Series.Remove(serie); //Remove
            _context.SaveChanges(); //Commit
            TempData["msg"] = "Excluido!"; //Mensagem
            return RedirectToAction("Listar");
        }



    }
}