using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Carrinho.Models;

namespace Carrinho.Controllers
{
    /// <summary>
    /// Controller referente ao objeto 'Compra' que é composto por um outro objeto, a saber, 'Produto' e 
    /// uma quantidade referente ao produto que está sendo comprado em questão. 
    /// </summary>
    public class CompraController : Controller
    {
        // Instancia do objeto ApplicationDbContext, criado automaticamente pelo
        private ApplicationDbContext db = new ApplicationDbContext();

        // POST: Compra/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken] //TODO: Pesquisar uma forma de criar uma validação de token por questões de segurança. 
        public ActionResult Create([Bind(Include = "ID,Quantidade,Produto")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                //O ID que está na compra na verdade é o id do produto.
                //Isso foi usadao de forma alternatica, pois não tive tempo hábil para pesquisar um parse pra json em 
                //objetos compostos

                compra.Produto = db.Produtoes.First(produto => produto.ID == compra.ID);
                db.Compras.Add(compra);
                db.SaveChanges();
            }

            return View(compra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
