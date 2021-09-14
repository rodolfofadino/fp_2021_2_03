﻿using fiapweb.core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace fiapweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Chuck";
            ViewBag.Sobrenome = "Noris";
            
            //acesso ao DB
            var pessoa = new Pessoa() { Nome="Maguila" };


            //return View("ViewQueNaoExiste");
            return View(pessoa);
        }

        public IActionResult Sobre()
        {
            return View();
        }
      
    }
}
