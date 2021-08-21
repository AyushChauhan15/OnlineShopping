using OnlineShoppingAPI.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlineShoppingAPI.Repository.Context
{
    public class OnlineShoppingDbContext : DbContext
    {

        public OnlineShoppingDbContext() : base("DefaultConnection") // name in web.config of Connection string.
        {
            //Database.SetInitializer(new OnlineShoppingTeam4DatabaseInitializer());
        }

        /// <summary>
        /// Context for Categories table in northwind database
        /// </summary>
        public virtual DbSet<Categories> Categories { get; set; }
        /// <summary>
        /// Context for CustomerDemographics table in northwind database
        /// </summary>
        public virtual DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        /// <summary>
        /// Context for Customers table in northwind database
        /// </summary>
        public virtual DbSet<Customers> Customers { get; set; }
        /// <summary>
        /// Context for Employees table in northwind database
        /// </summary>
        public virtual DbSet<Employees> Employees { get; set; }
        /// <summary>
        /// Context for Order_Details table in northwind database
        /// </summary>
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        /// <summary>
        /// Context for Orders table in northwind database
        /// </summary>
        public virtual DbSet<Orders> Orders { get; set; }
        /// <summary>
        /// Context for Persons table in northwind database
        /// </summary>

        /// <summary>
        /// Context for Products table in northwind database
        /// </summary>
        public virtual DbSet<Products> Products { get; set; }
        /// <summary>
        /// Context for Regions table in northwind database
        /// </summary>

        /// <summary>
        /// Context for Shippers table in northwind database
        /// </summary>
        /// 
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        /// <summary>
        /// Context for Territories table in northwind database
        /// </summary>

        /// <summary>
        /// Context for ShopCart table in northwind database
        /// </summary>
        public virtual DbSet<ShopCarts> ShopCart { get; set; }
        public virtual DbSet<WishLists> WishLists { get; set; }

        public virtual DbSet<Transactions> Transactions { get; set; }
        /// <summary>
        /// Build Information of Northwind DataBase
        /// </summary>
        /// <param name="modelBuilder"></param>
        //protected override void OnModelCreating_o(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<CustomerDemographics>()
        //        .Property(e => e.CustomerTypeID)
        //        .IsFixedLength();

        //    modelBuilder.Entity<CustomerDemographics>()
        //        .HasMany(e => e.Customers)
        //        .WithMany(e => e.CustomerDemographics)
        //        .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));

        //    modelBuilder.Entity<Customers>()
        //        .Property(e => e.CustomerID)
        //        .IsFixedLength();

        //    modelBuilder.Entity<Employees>()
        //        .HasMany(e => e.Employees1)
        //        .WithOptional(e => e.Employee1)
        //        .HasForeignKey(e => e.ReportsTo);



        //    modelBuilder.Entity<Order_Details>()
        //        .Property(e => e.UnitPrice)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Orders>()
        //        .Property(e => e.CustomerID)
        //        .IsFixedLength();

        //    modelBuilder.Entity<Orders>()
        //        .Property(e => e.Freight)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Orders>()
        //        .HasMany(e => e.Order_Details)
        //        .WithRequired(e => e.Order)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Products>()
        //        .Property(e => e.UnitPrice)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Products>()
        //        .HasMany(e => e.Order_Details)
        //        .WithRequired(e => e.Product)
        //        .WillCascadeOnDelete(false);



        //    modelBuilder.Entity<Shippers>()
        //        .HasMany(e => e.Orders)
        //        .WithOptional(e => e.Shipper)
        //        .HasForeignKey(e => e.ShipVia);




        //    modelBuilder.Entity<ShopCarts>()
        //        .HasRequired(a => a.Products)
        //        .WithMany()
        //        .HasForeignKey(a => a.ProductID);

        //    modelBuilder.Entity<ShopCarts>()
        //        .Property(e => e.UserName)
        //        .IsRequired();

        //    modelBuilder.Entity<ShopCarts>()
        //        .Property(e => e.Quantity)
        //        .IsRequired();

        //    modelBuilder.Entity<WishLists>()
        //       .HasRequired(a => a.Products)
        //       .WithMany()
        //       .HasForeignKey(a => a.ProductID);

        //    modelBuilder.Entity<WishLists>()
        //        .Property(e => e.UserName)
        //        .IsRequired();

        //    modelBuilder.Entity<WishLists>()
        //        .Property(e => e.Quantity)
        //        .IsRequired();
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDemographics>()
                .Property(e => e.CustomerTypeID)
                .IsFixedLength();

            modelBuilder.Entity<CustomerDemographics>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.CustomerDemographics)
                .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.ReportsTo);

            //modelBuilder.Entity<Employees>()
            //    .HasMany(e => e.Territories)
            //    .WithMany(e => e.Employees)
            //    .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Regions>()
            //    .Property(e => e.RegionDescription)
            //    .IsFixedLength();

            //modelBuilder.Entity<Region>()
            //    .HasMany(e => e.Territories)
            //    .WithRequired(e => e.Region)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shippers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            //modelBuilder.Entity<Territory>()
            //     .Property(e => e.TerritoryDescription)
            //     .IsFixedLength();

            modelBuilder.Entity<Transactions>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.CardHolderName)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.CVV)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.ExpiryMonth)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions>()
                .Property(e => e.ExpiryYear)
                .IsUnicode(false);

            //modelBuilder.Entity<users>()
            //    .Property(e => e.email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<user>()
            //    .Property(e => e.password)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Alphabetical_list_of_product>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Category_Sales_for_1997>()
            //    .Property(e => e.CategorySales)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Customer_and_Suppliers_by_City>()
            //    .Property(e => e.Relationship)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Invoice>()
            //    .Property(e => e.CustomerID)
            //    .IsFixedLength();

            //modelBuilder.Entity<Invoice>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Invoice>()
            //    .Property(e => e.ExtendedPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Invoice>()
            //    .Property(e => e.Freight)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Order_Details_Extended>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Order_Details_Extended>()
            //    .Property(e => e.ExtendedPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Order_Subtotal>()
            //    .Property(e => e.Subtotal)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Orders_Qry>()
            //    .Property(e => e.CustomerID)
            //    .IsFixedLength();

            //modelBuilder.Entity<Orders_Qry>()
            //    .Property(e => e.Freight)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Product_Sales_for_1997>()
            //    .Property(e => e.ProductSales)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Products_Above_Average_Price>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Sales_by_Category>()
            //    .Property(e => e.ProductSales)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Sales_Totals_by_Amount>()
            //    .Property(e => e.SaleAmount)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Summary_of_Sales_by_Quarter>()
            //    .Property(e => e.Subtotal)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Summary_of_Sales_by_Year>()
            //    .Property(e => e.Subtotal)
            //    .HasPrecision(19, 4);

        }
    }
}
