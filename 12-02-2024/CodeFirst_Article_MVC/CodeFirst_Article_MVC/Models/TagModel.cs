using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_Article_MVC.Models
{
    public class TagModel
    {
        [Key]
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
    }
}