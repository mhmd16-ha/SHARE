using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SHARE.Models
{
    public class ShareTool
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        public ShareTool(string Name, string Description, int Quantity)
        {
            this.Name = Name;
            this.Description = Description;
            this.Quantity = Quantity;

        }
        public ShareTool() { }
    }
 
}