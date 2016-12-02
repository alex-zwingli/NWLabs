using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWLabs.Areas.StaffPortal.Controllers
{
    public class StaffHomeController : Controller
    {
        // GET: StaffPortal/Home
        public ActionResult Index()
        {
            //Create multidimensional ist to store quotes and autor seperately
            string[] quotes = new string[2];
            List<string[]> quoteCatalog = new List<string[]>();
            quoteCatalog.Add(new string[2] {
                "There are no secrets to success. It is the result of preparation, hard work, and learning from failure.",
                "Colin Powell" });
            quoteCatalog.Add(new string[2] {
                "Our work is the presentation of our capabilities.",
                "Edward Gibbon" });
            quoteCatalog.Add(new string[2] {
                "Happiness does not come from doing easy work but from the afterglow of satisfaction that comes after the achievement of a difficult task that demanded our best.",
                "Theodore Isaac Rubin" });
            quoteCatalog.Add(new string[2] {
                "Happiness does not come from doing easy work but from the afterglow of satisfaction that comes after the achievement of a difficult task that demanded our best. ",
                "Theodore Isaac Rubin" });
            quoteCatalog.Add(new string[2] {
                "Ideas pull the trigger, but instinct loads the gun. ",
                "Don Marquis" });
            quoteCatalog.Add(new string[2] {
                "If you don't drive your business, you will be driven out of business. ",
                "B. C. Forbes" });
            quoteCatalog.Add(new string[2] {
                "Just because something doesn't do what you planned it to do doesn't mean it's useless. ",
                "Thomas A. Edison" });
            quoteCatalog.Add(new string[2] {
                "If you're trying to create a company, it's like baking a cake. You have to have all the ingredients in the right proportion. ",
                "Elon Musk" });
            quoteCatalog.Add(new string[2] {
                "People are definitely a company's greatest asset. It doesn't make any difference whether the product is cars or cosmetics. A company is only as good as the people it keeps. ",
                "Mary Kay Ash" });
            quoteCatalog.Add(new string[2] {
                "Rank does not confer privilege or give power. It imposes responsibility. ",
                "Peter Drucker" });
            quoteCatalog.Add(new string[2] {
                "Anyone who has lost track of time when using a computer knows the propensity to dream, the urge to make dreams come true and the tendency to miss lunch.",
                "Tim Berners-Lee" });
            quoteCatalog.Add(new string[2] {
                "A business that makes nothing but money is a poor business. Henry Ford",
                "Henry Ford" });

            //Randomly insert quote and author into viewbag. 
            Random rnd = new Random();
            int recall = rnd.Next(quoteCatalog.Count);
            ViewBag.quote = quoteCatalog[recall][0];
            ViewBag.author = quoteCatalog[recall][1];
            return View();
        }
    }
}