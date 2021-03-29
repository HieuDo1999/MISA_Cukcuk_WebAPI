using MISA_Cukcuk_WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA_Cukcuk_WebAPI
{
    public class DbContext
    {
        public static List<Customer> Customers = new List<Customer>();

        public static List<Customer> GetCustomer()
        {
            return Customers;
        }
        public int InsertCustomer(Customer customer)
        {
            return 1;
        }
        public int UpdateCustomer(Customer customer)
        {
            return 1;
        }
        public int Delete(Guid customerID)
        {
            return 1;
        }
    }
}
