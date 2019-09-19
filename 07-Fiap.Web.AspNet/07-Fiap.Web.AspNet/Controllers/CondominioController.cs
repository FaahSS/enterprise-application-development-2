using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class CondominioController : Controller
    {
        private BancoContext _context;
        public CondominioController(BancoContext context)
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
        public IActionResult Cadastrar(Condominio condominio)
        {
            _context.Condominios.Add(condominio);
            _context.SaveChanges();
            TempData["msg"] = "Condomínio cadastrado com Sucesso!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Listar()
        {
            //Include -> Inclui o relacionamento na pesquisa
            return View(_context.Condominios.Include(c => c.Sindico).ToList());
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var condominio = _context.Condominios.Include(c => c.Sindico).Where(c => c.CondominioId == id).FirstOrDefault();
            return View(condominio);
        }
        [HttpPost]
        public IActionResult Editar(Condominio condominio)
        {
            _context.Attach(condominio).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa)
        {
            var lista = _context.Condominios.Where(
                c => c.Nome.Contains(termoPesquisa)).Include(c=> c.Sindico).ToList();
            return View("Listar", lista);
        }
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var condominio = _context.Condominios.Find(id);
            _context.Condominios.Remove(condominio);
            _context.SaveChanges();
            TempData["msg"] = "Excluido!";
            return RedirectToAction("Listar");
        }
    }
}