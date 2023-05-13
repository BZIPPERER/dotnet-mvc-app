    // Erste Aenderung
using gameapplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace gameapplication.Models
{
    

 
    public class AccountViewModel
    {
        public Game Account { get; set; }

        //public List<Language> Languages { get; set; }

        //public SelectList Roles { get; set; }
        // string property in model class
        public string ExperienceLevel { get; set; }
    }

}