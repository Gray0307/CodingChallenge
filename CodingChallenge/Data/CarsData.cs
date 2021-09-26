using System;
using System.Collections.Generic;
using CodingChallenge.Models;

namespace CodingChallenge.Data
{
    public class CarsData : ICarsData
    {

        public List<CarViewModel> GetAllCars()
        {
                return new List<CarViewModel>{
                    new CarViewModel{
                        Id=1,
                        Brand= "Mercedes- Benz",
                        IsEcoFriendly= true,
                        Fuel = "Hybrid",
                        Models = new List<string>{"X1", "X2"}
                    },
                    new CarViewModel{
                        Id=2,
                        Brand= "Honda",
                        IsEcoFriendly= false,
                        Fuel = "Petrol",
                        Models = new List<string>{"X12", "X22"}
                    },
                    new CarViewModel{
                        Id=3,
                        Brand= "Tesla",
                        IsEcoFriendly= true,
                        Fuel = "Hybrid",
                        Models = new List<string>{"X14", "X25"}

                    },
                     new CarViewModel{
                        Id=4,
                        Brand= "Bentley",
                        IsEcoFriendly= true,
                        Fuel = "Hybrid",
                        Models = new List<string>{"R12", "B5"}

                    }
                };
        }
    }
}