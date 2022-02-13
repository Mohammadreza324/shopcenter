using System;
using System.Collections.Generic;
using System.Text;

namespace classer_beginner
{
    class ShopCenter
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Store> Stores { get; set; } = new List<Store>();
        public List<Office> Offices { get; set; } = new List<Office>();

    }
}
