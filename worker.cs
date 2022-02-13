using System;
using System.Collections.Generic;
using System.Text;

namespace classer_beginner
{
    class worker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void workerEntreTheBuilding(Office OfficeObj)
        {
            OfficeObj.workerEntre(this);
        }
    }
}
