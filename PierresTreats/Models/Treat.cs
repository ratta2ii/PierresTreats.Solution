using System.Collections.Generic;

namespace PierresTreats
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public virtual ICollection<FlavorTreat> Flavors { get; set; }
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }
        
    }
}