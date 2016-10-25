using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _404.Models
{
    public class Error404
    {
        [DisplayName("Please Enter What You Were Doing")]
        [StringLength(160, MinimumLength = 2)]
        public string UserMessage { get; set; }
    }
}