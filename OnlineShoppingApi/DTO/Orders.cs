﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class Orders
    {
        /// <summary>
        /// Default constructor. Initialises new empty instances for Order_Details.
        /// </summary>
        public Orders()
        {
            Order_Details = new HashSet<Order_Details>();
        }

        /// <summary>
        /// The id of the order.
        /// </summary>
       
        public int OrderID { get; set; }

        /// <summary>
        /// The id of the customer.
        /// </summary>
        
        public string CustomerID { get; set; }

        /// <summary>
        /// The id of the employee.
        /// </summary>
        public int? EmployeeID { get; set; }

        /// <summary>
        /// The date when the order was made.
        /// </summary>
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// The date when the order should arrive.
        /// </summary>
        public DateTime? RequiredDate { get; set; }

        /// <summary>
        /// The date when the order was shipped.
        /// </summary>
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// The id of the shipper.
        /// </summary>
        public int? ShipVia { get; set; }

        /// <summary>
        /// The freight of the order.
        /// </summary>
        
        public decimal? Freight { get; set; }

        /// <summary>
        /// The name of the shipper.
        /// </summary>
       
        public string ShipName { get; set; }

        /// <summary>
        /// The adress where the order is delivered.
        /// </summary>
       
        public string ShipAddress { get; set; }

        /// <summary>
        /// The city where the order is delivered.
        /// </summary>
      
        public string ShipCity { get; set; }

        /// <summary>
        /// The region where the order is delivered.
        /// </summary>
        
        public string ShipRegion { get; set; }

        /// <summary>
        /// The postal code where the order is delivered.
        /// </summary>
       
        public string ShipPostalCode { get; set; }

        /// <summary>
        /// The country where the order is delivered.
        /// </summary>
        
        public string ShipCountry { get; set; }

        /// <summary>
        /// The customer of the order.
        /// </summary>
        public virtual Customers Customer { get; set; }

        /// <summary>
        /// The employee who made the order.
        /// </summary>
        public virtual Employees Employee { get; set; }

        /// <summary>
        /// The details of the order.
        /// </summary>
        public virtual ICollection<Order_Details> Order_Details { get; }

        /// <summary>
        /// The shipper of the order.
        /// </summary>
        public virtual Shippers Shipper { get; set; }
    }
}
