using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace L2Object
{
    public class Customer
    {
        public Customer(string customerID, string companyName)
        {
            CustomerID = customerID;
            CompanyName = companyName;
            Orders = new Order[10];
        }
        public Customer()
        {

        }
        public string CustomerID;
        public string CompanyName;
        public string Address;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public string Fax;
        public Order[] Orders;
        public override string ToString()
        {
            return $"{CustomerID},{CompanyName},{Address},{City},{Region},{PostalCode},{Country},{Phone},{Fax}";
        }
    }
    public class Order
    {
        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }
        public Order()
        {

        }
        public int OrderID;
        public DateTime OrderDate;
        public decimal Total;
        public override string ToString()
        {
            return $"Order Id: {OrderID}, Date: {OrderDate.ToShortTimeString()}, Total: {Total}, ";
        }
    }
    public class Product : IComparable<Product>, IEqualityComparer<Product>
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }

        public int CompareTo(Product other) => UnitPrice.CompareTo(other?.UnitPrice);

        public bool Equals(Product x, Product y)
        {
            return x.UnitPrice == y.UnitPrice;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"ProductID:{ProductID},ProductName:{ProductName}," +
                $"Category:{Category},UnitPrice:{UnitPrice}," +
                $"UnitsInStock:{UnitsInStock}";
        }
    }

    public class ListGenerators
    {
        public static List<Customer> CustomerList;
        public static List<Product> ProductList;
        static ListGenerators()
        {
            #region CustomerList
            CustomerList = (
                from e in XDocument.Load("customers.xml").Root.Elements("customer")
                select new Customer
                {
                    CustomerID = (string)e.Element("id"),
                    CompanyName = (string)e.Element("name"),
                    Address = (string)e.Element("address"),
                    City = (string)e.Element("city"),
                    Region = (string)e.Element("region"),
                    PostalCode = (string)e.Element("postalcode"),
                    Country = (string)e.Element("country"),
                    Phone = (string)e.Element("phone"),
                    Fax = (string)e.Element("fax"),
                    Orders = (
                    from o in e.Element("orders").Elements("order")
                    select new Order
                    {
                        OrderID = (int)o.Element("id"),
                        OrderDate = DateTime.Parse((string)o.Element("orderdate")),
                        Total = decimal.Parse((string)o.Element("total"))
                    }).ToArray()
                }
                ).ToList();
            #endregion

            #region ProductList
            ProductList = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Widget", Category = "Electronics", UnitPrice = 59.99m, UnitsInStock = 100 },
                new Product { ProductID = 2, ProductName = "Sneakers", Category = "Apparel", UnitPrice = 79.99m, UnitsInStock = 0 },
                new Product { ProductID = 3, ProductName = "Headphones", Category = "Electronics", UnitPrice = 129.99m, UnitsInStock = 75 },
                new Product { ProductID = 4, ProductName = "T-shirt", Category = "Apparel", UnitPrice = 19.99m, UnitsInStock = 200 },
                new Product { ProductID = 5, ProductName = "Smartwatch", Category = "Electronics", UnitPrice = 199.99m, UnitsInStock = 30 },
                new Product { ProductID = 6, ProductName = "Jeans", Category = "Apparel", UnitPrice = 49.99m, UnitsInStock = 80 },
                new Product { ProductID = 7, ProductName = "Laptop", Category = "Electronics", UnitPrice = 899.99m, UnitsInStock = 20 },
                new Product { ProductID = 8, ProductName = "Dress Shirt", Category = "Apparel", UnitPrice = 39.99m, UnitsInStock = 150 },
                new Product { ProductID = 9, ProductName = "Tablet", Category = "Electronics", UnitPrice = 299.99m, UnitsInStock = 25 },
                new Product { ProductID = 10, ProductName = "Socks", Category = "Apparel", UnitPrice = 9.99m, UnitsInStock = 300 },
                new Product { ProductID = 11, ProductName = "Desktop PC", Category = "Electronics", UnitPrice = 1299.99m, UnitsInStock = 10 },
                new Product { ProductID = 12, ProductName = "Jacket", Category = "Apparel", UnitPrice = 69.99m, UnitsInStock = 70 },
                new Product { ProductID = 13, ProductName = "Smartphone", Category = "Electronics", UnitPrice = 699.99m, UnitsInStock = 40 },
                new Product { ProductID = 14, ProductName = "Skirt", Category = "Apparel", UnitPrice = 29.99m, UnitsInStock = 0 },
                new Product { ProductID = 15, ProductName = "Camera", Category = "Electronics", UnitPrice = 499.99m, UnitsInStock = 15 },
                new Product { ProductID = 16, ProductName = "Shorts", Category = "Apparel", UnitPrice = 24.99m, UnitsInStock = 90 },
                new Product { ProductID = 17, ProductName = "Printer", Category = "Electronics", UnitPrice = 199.99m, UnitsInStock = 12 },
                new Product { ProductID = 18, ProductName = "Hat", Category = "Apparel", UnitPrice = 14.99m, UnitsInStock = 200 },
                new Product { ProductID = 19, ProductName = "Wireless Earbuds", Category = "Electronics", UnitPrice = 79.99m, UnitsInStock = 25 },
                new Product { ProductID = 20, ProductName = "Scarf", Category = "Apparel", UnitPrice = 19.99m, UnitsInStock = 150 },
                new Product { ProductID = 21, ProductName = "Backpack", Category = "Accessories", UnitPrice = 39.99m, UnitsInStock = 100 },
                new Product { ProductID = 22, ProductName = "Gaming Mouse", Category = "Electronics", UnitPrice = 49.99m, UnitsInStock = 50 },
                new Product { ProductID = 23, ProductName = "Running Shoes", Category = "Footwear", UnitPrice = 89.99m, UnitsInStock = 0 },
                new Product { ProductID = 24, ProductName = "Yoga Mat", Category = "Fitness", UnitPrice = 19.99m, UnitsInStock = 200 },
                new Product { ProductID = 25, ProductName = "Smart Thermostat", Category = "Home Automation", UnitPrice = 149.99m, UnitsInStock = 30 },
                new Product { ProductID = 26, ProductName = "Dumbbells Set", Category = "Fitness", UnitPrice = 69.99m, UnitsInStock = 80 },
                new Product { ProductID = 27, ProductName = "External Hard Drive", Category = "Computers", UnitPrice = 129.99m, UnitsInStock = 20 },
                new Product { ProductID = 28, ProductName = "Kitchen Blender", Category = "Appliances", UnitPrice = 59.99m, UnitsInStock = 150 },
                new Product { ProductID = 29, ProductName = "Wireless Speaker", Category = "Electronics", UnitPrice = 99.99m, UnitsInStock = 0 },
                new Product { ProductID = 30, ProductName = "Snowboard", Category = "Sports", UnitPrice = 299.99m, UnitsInStock = 300 },
                new Product { ProductID = 31, ProductName = "Guitar", Category = "Musical Instruments", UnitPrice = 199.99m, UnitsInStock = 10 },
                new Product { ProductID = 32, ProductName = "Microwave Oven", Category = "Kitchen Appliances", UnitPrice = 149.99m, UnitsInStock = 70 },
                new Product { ProductID = 33, ProductName = "Power Drill", Category = "Tools", UnitPrice = 79.99m, UnitsInStock = 40 },
                new Product { ProductID = 34, ProductName = "Sunglasses", Category = "Accessories", UnitPrice = 29.99m, UnitsInStock = 120 },
                new Product { ProductID = 35, ProductName = "Cycling Helmet", Category = "Sports", UnitPrice = 39.99m, UnitsInStock = 15 },
                new Product { ProductID = 36, ProductName = "Digital Camera", Category = "Photography", UnitPrice = 399.99m, UnitsInStock = 90 },
                new Product { ProductID = 37, ProductName = "Gaming Console", Category = "Entertainment", UnitPrice = 499.99m, UnitsInStock = 12 },
                new Product { ProductID = 38, ProductName = "Tennis Racket", Category = "Sports", UnitPrice = 59.99m, UnitsInStock = 0 },
                new Product { ProductID = 39, ProductName = "Sleeping Bag", Category = "Outdoor Gear", UnitPrice = 79.99m, UnitsInStock = 25 },
                new Product { ProductID = 40, ProductName = "Wireless Router", Category = "Networking", UnitPrice = 99.99m, UnitsInStock = 150 },
                new Product { ProductID = 41, ProductName = "Camping Tent", Category = "Outdoor Gear", UnitPrice = 149.99m, UnitsInStock = 200 },
                new Product { ProductID = 42, ProductName = "Fitness Tracker", Category = "Wearables", UnitPrice = 79.99m, UnitsInStock = 30 },
                new Product { ProductID = 43, ProductName = "Monitor Stand", Category = "Office Supplies", UnitPrice = 29.99m, UnitsInStock = 100 },
                new Product { ProductID = 44, ProductName = "Portable Charger", Category = "Electronics", UnitPrice = 19.99m, UnitsInStock = 150 },
                new Product { ProductID = 45, ProductName = "Back Support Pillow", Category = "Home", UnitPrice = 24.99m, UnitsInStock = 200 },
                new Product { ProductID = 46, ProductName = "Desktop Speakers", Category = "Computers", UnitPrice = 49.99m, UnitsInStock = 75 },
                new Product { ProductID = 47, ProductName = "BBQ Grill", Category = "Outdoor Cooking", UnitPrice = 199.99m, UnitsInStock = 40 },
                new Product { ProductID = 48, ProductName = "Leather Wallet", Category = "Accessories", UnitPrice = 39.99m, UnitsInStock = 100 },
                new Product { ProductID = 49, ProductName = "Projector", Category = "Home Theater", UnitPrice = 299.99m, UnitsInStock = 20 },
                new Product { ProductID = 50, ProductName = "Drone", Category = "Electronics", UnitPrice = 499.99m, UnitsInStock = 30 },
                new Product { ProductID = 51, ProductName = "Painting Kit", Category = "Arts & Crafts", UnitPrice = 29.99m, UnitsInStock = 150 },
                new Product { ProductID = 52, ProductName = "Running Jacket", Category = "Apparel", UnitPrice = 59.99m, UnitsInStock = 80 },
                new Product { ProductID = 53, ProductName = "Wall Clock", Category = "Home Decor", UnitPrice = 19.99m, UnitsInStock = 200 },
                new Product { ProductID = 54, ProductName = "Bluetooth Keyboard", Category = "Computers", UnitPrice = 49.99m, UnitsInStock = 75 },
                new Product { ProductID = 55, ProductName = "Rolling Backpack", Category = "Travel Gear", UnitPrice = 69.99m, UnitsInStock = 40 },
                new Product { ProductID = 56, ProductName = "Coffee Maker", Category = "Appliances", UnitPrice = 79.99m, UnitsInStock = 100 },
                new Product { ProductID = 57, ProductName = "Fishing Rod", Category = "Outdoor Gear", UnitPrice = 89.99m, UnitsInStock = 25 },
                new Product { ProductID = 58, ProductName = "Water Bottle", Category = "Accessories", UnitPrice = 9.99m, UnitsInStock = 500 },
                new Product { ProductID = 59, ProductName = "Umbrella", Category = "Accessories", UnitPrice = 14.99m, UnitsInStock = 300 },
                new Product { ProductID = 60, ProductName = "Desk Lamp", Category = "Office Supplies", UnitPrice = 29.99m, UnitsInStock = 150 },
                new Product { ProductID = 61, ProductName = "Yoga Blocks", Category = "Fitness", UnitPrice = 14.99m, UnitsInStock = 100 },
                new Product { ProductID = 62, ProductName = "Electric Toothbrush", Category = "Personal Care", UnitPrice = 39.99m, UnitsInStock = 50 },
                new Product { ProductID = 63, ProductName = "Basketball", Category = "Sports", UnitPrice = 29.99m, UnitsInStock = 200 },
                new Product { ProductID = 64, ProductName = "Cycling Gloves", Category = "Apparel", UnitPrice = 19.99m, UnitsInStock = 150 },
                new Product { ProductID = 65, ProductName = "External SSD Drive", Category = "Computers", UnitPrice = 199.99m, UnitsInStock = 30 },
                new Product { ProductID = 66, ProductName = "Smart Lock", Category = "Home Automation", UnitPrice = 99.99m, UnitsInStock = 40 },
                new Product { ProductID = 67, ProductName = "Snow Gloves", Category = "Apparel", UnitPrice = 24.99m, UnitsInStock = 100 },
                new Product { ProductID = 68, ProductName = "Dining Table", Category = "Furniture", UnitPrice = 299.99m, UnitsInStock = 5 },
                new Product { ProductID = 69, ProductName = "Sunscreen", Category = "Personal Care", UnitPrice = 9.99m, UnitsInStock = 200 },
                new Product { ProductID = 70, ProductName = "Plant Pot", Category = "Home Decor", UnitPrice = 19.99m, UnitsInStock = 150 }
            };



            #endregion
           


        }

    }
}
