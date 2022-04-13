using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHARE.Models
{
    public class ShareTool
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public ShareTool(string Name, string Description, int Quantity)
        {
            this.Name = Name;
            this.Description = Description;
            this.Quantity = Quantity;

        }
    }
 
}