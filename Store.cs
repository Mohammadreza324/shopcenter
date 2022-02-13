using System;
using System.Collections.Generic;
using System.Text;

namespace classer_beginner
{
    class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Item { get; set; }

        public ShopCenter shopCenter { get; set; } = new ShopCenter();

    }
}
