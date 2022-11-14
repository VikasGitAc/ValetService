using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValetService.GUI
{
    public class Car { 
        public int CheckIn_Id { get; set; }

        public int Slip_Id { get; set; }
        public int Room_No { get; set; }
        public string Model { get; set; }
        public string PrakingLot { get; set; }
        public string Parking_Spot { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Boolean Car_In { get; set; }
        public Boolean Car_Out { get; set; }

    }
}
