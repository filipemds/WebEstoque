using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebEstoque.DAO;
using WebEstoque.Models;

namespace WebEstoque.Controllers
{
    public class MercadoriaController : Controller
    {
        //
        // GET: /Mercadoria/
        [Route("mercadorias", Name = "ListaMercadorias")]
        public ActionResult Index()
        {
            MercadoriaDAO dao = new MercadoriaDAO();
            var mercadorias = dao.Listar();
            return View(mercadorias);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public ActionResult Adicionar(Mercadoria mercadoria)
        {
            if (ModelState.IsValid)
            {
                MercadoriaDAO dao = new MercadoriaDAO();
                dao.Adicionar(mercadoria);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Mercadoria = mercadoria;
                return View("Form");
            }
        }

    }
}