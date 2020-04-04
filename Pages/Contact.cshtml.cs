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
    public class ContactModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Name")]
        [Required]
        [StringLength(16)]
        public string name {get; set;}


        [BindProperty]
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string email {get; set;}

        [BindProperty]
        [Display(Name = "Message")]
        [Required]
        public string msg {get; set;}


        private readonly ILogger<IndexModel> _logger;

        public ContactModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _logger.LogInformation($"OnPost() called\n name: {name}\nemail: {email}\n {msg}");
            ViewData["name"] = $"Thank you for your message! {name} ({email}):\n{msg}";
        }
    }
}
