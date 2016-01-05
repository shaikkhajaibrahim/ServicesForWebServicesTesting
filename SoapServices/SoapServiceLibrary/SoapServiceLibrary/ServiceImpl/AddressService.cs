using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapServiceLibrary.Definitions;
using SoapServices.DAL.EducationalInstitution;

namespace SoapServiceLibrary.ServiceImpl
{
    /// <summary>
    /// Address Service
    /// </summary>
    public class AddressService : IAddressService
    {
        /// <summary>
        /// Add address
        /// </summary>
        /// <param name="address"></param>
        public void AddAddress(Definitions.Address address)
        {
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                context.Addresses.Add(new SoapServices.DAL.EducationalInstitution.Address()
                {
                    City = address.City,
                    Country = address.Country,
                    State = address.State,
                    StreetLine1 = address.StreetLine1,
                    StreetLine2 = address.StreetLine2
                });
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Returns all the distinct cites
        /// </summary>
        /// <returns></returns>
        public string[] FindAllDistinctCities()
        {
            string[] cities = null;
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                cities=context.Addresses.Select(item => item.City).Distinct().ToArray();
            }
            return cities;

        }
    }
}
