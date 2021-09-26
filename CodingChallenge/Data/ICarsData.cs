using System;
using System.Collections.Generic;
using CodingChallenge.Models;

namespace CodingChallenge.Data
{
    public interface ICarsData
    {
        List<CarViewModel> GetAllCars();
    } 
}