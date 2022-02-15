using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Website.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.Website.Pages
{//a page number that is the buddy for the index.html
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; } //only this class can set them

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)//logging is a service provided by Asp.net you ask for one by asking for it in args. 
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()//when someone gets this page
        {
            Products = ProductService.GetProducts();
        }
    }
}
