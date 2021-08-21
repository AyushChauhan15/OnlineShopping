using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class Suppliers
    {

        /// <summary>
        /// Default constructor. Initialises new empty instances for Products.
        /// </summary>
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }

        /// <summary>
        /// The id of the supplier.
        /// </summary>
       
        public int SupplierID { get; set; }

        /// <summary>
        /// The name of the company who is the supplier.
        /// </summary>
        
        public string CompanyName { get; set; }

        /// <summary>
        /// The name of the contact person from the company.
        /// </summary>
        
        public string ContactName { get; set; }

        /// <summary>
        /// The function of the contact person.
        /// </summary>
       
        public string ContactTitle { get; set; }

        /// <summary>
        /// The address of the supplier.
        /// </summary>
       
        public string Address { get; set; }

        /// <summary>
        /// The supplier's city.
        /// </summary>
        
        public string City { get; set; }

        /// <summary>
        /// The supplier's region.
        /// </summary>
       
        public string Region { get; set; }

        /// <summary>
        /// The supplier's postal code.
        /// </summary>
        
        public string PostalCode { get; set; }

        /// <summary>
        /// The supplier's country.
        /// </summary>
       
        public string Country { get; set; }

        /// <summary>
        /// The phone number of the supplier.
        /// </summary>
       
        public string Phone { get; set; }

        /// <summary>
        /// The fax of the supplier.
        /// </summary>
       
        public string Fax { get; set; }

        /// <summary>
        /// The supplier's web site.
        /// </summary>
      
        public string HomePage { get; set; }

        
        public string Email { get; set; }

        /// <summary>
        /// The supplier's city.
        /// </summary>
        
        public string Password { get; set; }
        /// <summary>
        /// The products delivered by the supplier.
        /// </summary>
        public virtual ICollection<Products> Products { get; set; }
    }
}
