using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        [Display(Name = "Superhero")]
        [Required(ErrorMessage = "The Superhero field is required.")]
        public string Superhero { get; set; }

        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost()
        {
            return RedirectToPage("Index");
        }
    }
}
