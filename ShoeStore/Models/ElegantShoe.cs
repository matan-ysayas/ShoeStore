using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStore.Models
{
    public class ElegantShoe
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public string Gender {get;set;}

        public bool HasHeel { get; set; }

        public bool HasInStock { get; set; }
        public int Size { get; set; }

    public int Price { get; set; }

    }
}