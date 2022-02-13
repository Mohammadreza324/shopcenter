using System;

namespace classer_beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopCenter Femman = new ShopCenter();


            Store Store1 = new Store();
            Store1.Id = 1;
            Store1.Name = "Hemköp";
            Store1.Item = "Food Store";
            Store1.Area = 10000;

            Store1.shopCenter = Femman;
            Femman.Stores.Add(Store1);

            //Använder mig av kontruktör
            //Office Office1 = new Office(1, "Hemköp Office", 2, 20);
            Office Office1 = new Office();
            Office1.OfficeId = 1;
            Office1.OfficeName = "Hemköp Office";
            worker worker1 = new worker();
            worker1.Id = 1;
            worker1.Name = "Reza";

            worker1.workerEntreTheBuilding(Office1);


            
        }
    }
}
