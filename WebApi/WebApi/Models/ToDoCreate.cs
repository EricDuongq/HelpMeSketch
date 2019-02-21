using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ToDoCreate
    {
        [Required]
        public string Task { get; set; }
    }
}