using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace supinfo._3asp.koombu.Models
{
    public class PostViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        

    }
}