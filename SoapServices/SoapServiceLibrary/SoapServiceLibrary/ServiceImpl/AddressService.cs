using System;
using System.Linq;
using SoapServices.DAL.EducationalInstitution;
using log4net;

namespace SoapServiceLibrary.ServiceImpl
{
    /// <summary>
    /// Address Service
    /// </summary>
    public class AddressService : IAddressService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(AddressService));
        /// <summary>
        /// Add address
        /// </summary>
        /// <param name="address"></param>
        public void AddAddress(Definitions.Address address)
        {
            Log.DebugFormat("Received Request for AddAddress with following values {0}", address);
            
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                context.Addresses.Add(new Address()
                {
                    City = address.City,
                    Country = address.Country,
                    State = address.State,
                    StreetLine1 = address.StreetLine1,
                    StreetLine2 = address.StreetLine2
                });
                context.SaveChanges();
            }
            Log.Debug("Processed Request for Add Address");
        }

        /// <summary>
        /// Count of the Addresses By City
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public int CountOfAddressesByCity(string city)
        {
            Log.DebugFormat("Received Request for CountOfAddressedByCity with city={0}", city);
            int count = 0;
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                count = context.Addresses.Count(item => item.City.Equals(city,StringComparison.OrdinalIgnoreCase));
            }
            Log.DebugFormat("Processed Request and count is {0}", count);
            return count;

        }

        /// <summary>
        /// Returns all the distinct cites
        /// </summary>
        /// <returns></returns>
        public string[] FindAllDistinctCities()
        {
            Log.Debug("Received Request for FindAllDistinctCities");
            string[] cities = null;
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                cities=context.Addresses.Select(item => item.City).Distinct().ToArray();
                
            }
            if(cities!=null)
            {
                Log.DebugFormat("Processed Request & Sending the following response {0}",
                string.Join(",", cities));
            }
            return cities;

        }
    }
}
