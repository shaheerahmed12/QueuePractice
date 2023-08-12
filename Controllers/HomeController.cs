using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using queue.Models.Queue;

namespace queue.Controllers
{
    public class HomeController : Controller
    {
        run r=new run();
        public int Index()
        {
           return r.Runner();
            
        }

    }
}