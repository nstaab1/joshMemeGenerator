using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Web.Models;
using Project.Web.DAL;

namespace Project.Web.Controllers
{
    public class CardController : Controller
    {
        private ITemplateDAL dal;

        //created a constructor for PostController
        public CardController(ITemplateDAL aName)
        {
            this.dal = aName;
        }

        // GET: Card
        public ActionResult TemplatePicker()
        {         
            List<Templates> model = dal.GetAllTemplates();
            return View("TemplatePicker", model);
        }

        [HttpGet]
        public ActionResult TemplateGenerator(int id)
        {
            Templates model = dal.GetATemplate(id);
            return View("TemplateGenerator", model);
        }

        
        public ActionResult CardResult(Card model)
        {

            Session["CardFinal"] = model;
            return View("CardResult", model);
        }

        [HttpPost]
        public ActionResult SaveImage()
        {

            Card model = Session["CardFinal"] as Card;
            model.SaveImage();
            return View("SaveImage", model);
        }

        public ActionResult GetRandomMeme()
        {
            Card model = dal.GetARandomMeme(1);
            return View("GetRandomMeme", model);
        }

    }
}