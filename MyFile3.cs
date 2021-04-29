using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OfcDetail
    {
        public int PostId { get; set; }
        public string Location { get; set; }

        public string MyName { get; set; }
    }
}