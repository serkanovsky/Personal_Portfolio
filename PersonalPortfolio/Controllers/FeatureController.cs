﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Duzenleme";
            ViewBag.v2 = "One Cikanlar";
            ViewBag.v3 = "One Cikan Sayfasi";
            var values = featureManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }

    }
}

