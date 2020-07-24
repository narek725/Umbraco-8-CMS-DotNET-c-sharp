﻿using TotalCode.Core.Models.Pages;
using TotalCode.Core.Pages.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TotalCode.Core.Controllers.Pages
{
    public class TotalCodeMarketingPageController : BasePageController
    {
        public ActionResult Index()
        {
            var model = GetModel<MarketingPageViewModel>(CurrentPage);
            return CurrentTemplate(model);
        }
    }
}
