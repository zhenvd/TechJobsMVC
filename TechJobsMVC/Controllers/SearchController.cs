﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVC.Data;
using TechJobsMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        // TODO #3: Create an action method to process a search request and render the updated search view. 
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Job> jobs;
            //if(searchTerm == "")
            if(String.IsNullOrEmpty(searchTerm))
            {
                jobs = JobData.FindAll();
                //ViewBag.jobs = jobs;
                //ViewBag.columns = ListController.ColumnChoices;
                //return View("~/Views/Search/Index.cs
            }
            else
            {
                jobs= JobData.FindByColumnAndValue(searchType, searchTerm);
                //ViewBag.jobs = jobs;
                //ViewBag.columns = ListController.ColumnChoices;
                //return View("~/Views/Search/Index.cshtml");
            }
            ViewBag.jobs = jobs;
            ViewBag.columns = ListController.ColumnChoices;
            ViewBag.title = "Jobs with " + ListController.ColumnChoices[searchType] + ": " + searchTerm;
            return View("~/Views/Search/Index.cshtml");
        }
    }
}
