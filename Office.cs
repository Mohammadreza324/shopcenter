using System;
using System.Collections.Generic;
using System.Text;

namespace classer_beginner
{
    class Office
    {
        public int OfficeId { get; set; }
        public String OfficeName { get; set; }
        public int OfficeFloorNummber { get; set; }
        public int OfficeWorkers { get; set; }

        //skapandet av kunstruktör
        //public Office (int aId, string aName, int aFloorNummber, int aWorkers)
        //{
        //    this.Id = aId;
        //    this.Name = aName;
        //    this.FloorNummber = aFloorNummber;
        //    this.Workers = aWorkers;
        //}
        //public ShopCenter shopCenter { get; set; } = new ShopCenter();
        public void workerEntre(worker workerObj)
        {
            Console.WriteLine($"The worker {workerObj.Name} with id nummer {workerObj.Id} have entred the {OfficeName}.");
        }
    }
}
