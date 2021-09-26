
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CodingChallenge.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }   
        public bool IsEcoFriendly { get; set; } 

        [DisplayName("Fuel Type")]
        public string Fuel { get; set; }
        public List<string> Models { get; set; }
        public List<SelectCar>   AllCars { get; set; }
    }
}