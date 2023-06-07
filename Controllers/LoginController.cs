using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_projeto_gamer.infra;
using MVC_projeto_gamer.Models;

namespace MVC_projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [TempData]
        public string Message{ get;set;}

        Context c = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar (IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador JogadorBuscado = c.Jogador.FirstOrDefault(j => j.Email == email && j.Senha == senha);

            //Aqui precisamos implementar a sessao

            if (JogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", JogadorBuscado.Nome);
                return LocalRedirect("~/");
            }
            Message = "Dados invalidos";

            return LocalRedirect("~/Login/Login");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}