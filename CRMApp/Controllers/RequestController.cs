﻿using CRMApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApp.Controllers
{
    public class RequestController:Controller
    {
        public IActionResult Apply()
        {
            return View();
        }
        public async Task<IActionResult> Apply(RequestViewModel model)
        {
            
            return View();
        }
    }
}
