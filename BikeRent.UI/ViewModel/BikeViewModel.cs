using BikeRent.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRent.UI.ViewModel
{
    public class BikeViewModel
    {
        public string  Name { get; set; }
        public TypeEnum Type { get; set; }
        public int Price { get; set; }
    }
}
