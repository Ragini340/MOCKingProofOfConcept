using Microsoft.AspNetCore.Mvc;
using MOCKingProofOfConcept.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCKingProofOfConcept.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetDataRepository _data;

        public HomeController(IGetDataRepository data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }
    }
}

