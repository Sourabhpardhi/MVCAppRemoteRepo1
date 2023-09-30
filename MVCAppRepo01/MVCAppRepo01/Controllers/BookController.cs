using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppRepo01.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
    }
}
