using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using BusinessFlow.Models;
using BusinessFlow.Models.AccountViewModels;
using BusinessFlow.Services;
namespace BusinessFlow.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bid()
        {
            return View();
        }
        public IActionResult Part()
        {
            return View();
        }
    }      
}