using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> ItemsFound { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered Categories
        /// </summary>
        public string[] Category { get; set; }

        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum IMDB Rating
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum IMDB Rating
        /// </summary>
        public double? PriceMax { get; set; }

        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax, string SearchTerms)
        {
            this.SearchTerms = SearchTerms;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            ItemsFound = Menu.Search(Menu.FullMenu(), SearchTerms);
            ItemsFound = Menu.FilterByCategory(Menu.FullMenu(), Category);
            ItemsFound = Menu.FilterByCalories(ItemsFound, CaloriesMin, CaloriesMax);
            ItemsFound = Menu.FilterByPrice(ItemsFound, PriceMin, PriceMax);
        }
    }
}
