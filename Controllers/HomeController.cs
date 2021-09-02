using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sembanco.Models;

namespace sembanco.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Trabalhe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Trabalhe(Candidato trabalhador)
        {
            Banco.newCliente.cadastroCandidato(trabalhador);
            ViewBag.Mensagem = "Cadastro Realizado";
            return View();
            
        }
        public IActionResult Institucional()
        {
            return View();

        }
            public IActionResult Cadastro()
        {

            return View();
        }
            
        [HttpPost]
        public IActionResult Cadastro(Cliente cliente1)
        {
            Banco.newCliente.cadastroCliente(cliente1);
            ViewBag.Mensagem = "Cadastro Realizado";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Cliente clienteLogin)
        {
            return RedirectToAction("Acesso", "Home");
        }

        public IActionResult Acesso()
        {
           var lista =  Banco.newCliente.mostrar();
           return View(lista);
        }
        public IActionResult Sacar()
        {
            return View();

        }

        public IActionResult Depositar()
        {
            return View();
        }

       
       

    }
}
