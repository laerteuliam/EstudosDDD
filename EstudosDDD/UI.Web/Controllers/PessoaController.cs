using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudosDDD.Application.Contracts;
using EstudosDDD.Application.Dtos;

namespace UI.Web.Controllers
{
    public class PessoaController : Controller
    {
        private IPessoaApplicationService _pessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
        }
        
        // GET: Pessoa
        public ActionResult Index()
        {
            var lista = _pessoaApplicationService.Listar().ToList().ConvertAll(Converters.Pessoa.PessoaConverter.ToModel);
            return View(lista);
        }
    }
}