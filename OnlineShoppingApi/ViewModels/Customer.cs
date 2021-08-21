using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingAPI.ViewModels
{
    /// <summary>
    /// New customer from ShopCart
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The name of the company which is the customer.
        /// </summary>
        
        
        public string CompanyName { get; set; }

        
        /// <summary>
        /// The function of the contact person.
        /// </summary>
       
        public string ContactTitle { get; set; }

        /// <summary>
        /// The adress of the customer.
        /// </summary>
       
        public string Address { get; set; }

        /// <summary>
        /// The customer's city.
        /// </summary>
       
        public string City { get; set; }

        /// <summary>
        /// The customer's region.
        /// </summary>
        
        public string Region { get; set; }

        /// <summary>
        /// The customer's postal code.
        /// </summary>
       
        public string PostalCode { get; set; }

        /// <summary>
        /// The customer's country.
        /// </summary>
       
        public string Country { get; set; }

        /// <summary>
        /// The phone number of the customer.
        /// </summary>
       
        public string Phone { get; set; }

        /// <summary>
        /// The fax of the customer.
        /// </summary>
        
        public string Fax { get; set; }
    }
}