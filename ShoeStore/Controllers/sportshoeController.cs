using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStore.Controllers
{
    public class sportshoeController : Controller
    {
        public SportShoe[] SportShoesArray = new SportShoe[] { new SportShoe(1, "adidas", "bla", 45, 500), new SportShoe(2, "nike", "air", 42, 350), new SportShoe(3, "puma", "ASA", 40, 700), new SportShoe(4, "vans", "old", 46, 400) };
        // GET: sportshoe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getModelName()
        {
            return View(SportShoesArray[0]);
        }

        public ActionResult GetShoe(int Id)
        {
            SportShoe sportShoe = SportShoesArray.First((item)=>item.Id==Id);
            return View(sportShoe);
        }

        public ActionResult GetAllShoes()
        {
            return View(SportShoesArray);
        }
    }
}