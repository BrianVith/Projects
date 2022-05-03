using SurfsUpIdentity.Data;
using SurfsUpIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Utility
{
    public class UserCreationChecker
    {
        private readonly ApplicationDbContext _context;

        public UserCreationChecker(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CityCheck(string cityName, int postalCode)
        {
            if (_context.Citys.Any(x => x.PostalCode == postalCode))
            {
                return  _context.Citys.Single(x => x.PostalCode == postalCode).CityId;
            }

            City newCity = new City() {CityName=cityName, PostalCode = postalCode };
            _ = _context.Citys.Add(newCity);
            _ = _context.SaveChanges();
            return newCity.CityId;
        }
    }
}
