﻿using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Controllers;
using NewBrandingStyle.Web.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class LatestItem : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;
        public LatestItem(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items.OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }
    }
}
