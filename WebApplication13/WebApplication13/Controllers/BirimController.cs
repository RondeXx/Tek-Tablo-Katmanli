using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class BirimController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.Birimis.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim d)
        {
            c.Birimis.Add(d);
            c.SaveChanges() ;
            return RedirectToAction("Index");
            
        }
        
        public IActionResult BirimSil (int id) 
        {
            var dep = c.Birimis.Find(id);
            c.Birimis.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimGetir(int id)
        {
            var depart = c.Birimis.Find(id);
            return View("BirimGetir", depart);
        }
        public IActionResult BirimGuncelle(Birim b)
        {
            var dep = c.Birimis.Find(b.BirimID);
            dep.BirimAd = b.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
