using System;
using System.Collections.Generic;

namespace DataMiner
{
    class Invoice
    {
        Dictionary<Product, int> order = new Dictionary<Product, int>();

        string invoiceNumber;
        Customer customer;
        DateTime transactionTime;

        public Customer Customer
        {
            get
            {
                return customer;
            }
            private set
            {
                customer = value;
            }
        }

        public DateTime TransactionTime
        {
            get
            {
                return transactionTime;
            }
            private set
            {
                transactionTime = value;
            }
        }

        public string InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            private set
            {
                invoiceNumber = value;
            }
        }
        
        public Dictionary<Product, int> Order
        {
        	get
        	{
        		return order;
        	}
        }

        public Invoice(string invoiceNumber, Customer customer, DateTime transactionTime)
        {
            InvoiceNumber = invoiceNumber;
            Customer = customer;
            TransactionTime = transactionTime;
        }

        /// <summary>
        /// Adds a product to an invoice
        /// </summary>
        /// <param name="product">The product to be added</param>
        /// <param name="quantity">How many of the product to add (default is one)</param>
        public void AddProduct(Product product, int quantity)
        {
            KeyValuePair<Product, int> foundPair = new KeyValuePair<Product, int>();
            foreach (KeyValuePair<Product, int> pair in order)
            {
                if (pair.Key == product)
                    foundPair = pair;
            }

            order.Remove(product);
            order.Add(product, foundPair.Value + quantity);
        }

        /// <summary>
        /// Find the total quantity of products on an invoice
        /// </summary>
        /// <returns>The quantity of items</returns>
        public int TotalQuantity()
        {
            int total = 0;
            foreach (KeyValuePair<Product, int> item in order)
            {
                total += item.Value;
            }
            return total;
        }

        /// <summary>
        /// Find the total value of products on an invoice
        /// </summary>
        /// <returns>The value of items</returns>
        public float TotalValue()
        {
            float total = 0.0f;
            foreach (KeyValuePair<Product, int> item in order)
            {
                total += item.Key.UnitPrice * item.Value;
            }
            return total;
        }
    }
}
