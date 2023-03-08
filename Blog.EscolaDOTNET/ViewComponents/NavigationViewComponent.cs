﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.EscolaDOTNET.ViewComponents {
    public class NavigationViewComponent : ViewComponent {
        public async Task<IViewComponentResult> InvokeAsync() {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}