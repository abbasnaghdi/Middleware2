﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Middleware.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string s;
        public void OnGet()
        {
            ViewData["Message"] = "hello github";
            ViewData["date"] = DateTime.Now.ToString();
             s = "ali";
        }
    }
}