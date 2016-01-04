using SoapServiceLibrary.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapServiceLibrary
{
    /// <summary>
    /// This interface is Service Contract for Soap 
    /// </summary>
    [ServiceContract]
    public interface IAddressService
    {
        /// <summary>
        /// This method is used to Address
        /// </summary>
        /// <param name="address"></param>
        [OperationContract]
        void AddAddress(Address address);
    }
}
