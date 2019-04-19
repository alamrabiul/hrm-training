using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Section
    {
        public int Id { get; set; }
        [Display(Name = "Section Code")]
        public string Name { get; set; }
        

        public string SectionCode { get; set; }
        [Display(Name = "Section Name")]
        [StringLength(150)]
        public string SectionName { get; set; }


        
        
    }
}