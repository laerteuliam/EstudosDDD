using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EstudosDDD.Application.Contracts;
using EstudosDDD.UI.Web.Converters.Pessoa;
using EstudosDDD.UI.Web.Models.Pessoa;

namespace EstudosDDD.UI.Web.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
        }

        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Salvar(IndexModel model)
        {
            model.DataNascimento = DateTime.Now;
            _pessoaApplicationService.Salvar(model.ToDto());
        }

        [HttpPost]
        public JsonResult Listar()
        {
            List<IndexModel> lista = _pessoaApplicationService.Listar().ToList().ConvertAll(PessoaConverter.ToModel);
            return Json(lista);
        }
    }
}