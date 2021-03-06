using System.Collections.Generic;

namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public virtual ApplicationUser User { get; set; }  // Registration & Login
        public virtual ICollection<FlavorTreat> Flavors { get; set; }
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }       
    }

}