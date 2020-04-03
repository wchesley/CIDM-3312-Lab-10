using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_10.Pages
{
    public class lab10Model : PageModel
    {
        [BindProperty]
        [Required]
        [StringLength(16)]
        public string fname {get; set;}


        [BindProperty]
        [Required]
        [StringLength(16)]
        public string lname {get; set;}

        [BindProperty]
        [Required]
        [CreditCard]
        public string CCnum {get; set;}


        private readonly ILogger<IndexModel> _logger;

        public lab10Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _logger.LogInformation($"OnPost() called\nfname: {fname}\nlname: {lname}\n {CCnum}");
            ViewData["name"] = fname + " " + lname;
        }
    }
}
