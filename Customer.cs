using System;
using System.Collections.Generic;

namespace DataMiner
{
    class Customer
    {
        string id;
        List<Invoice> invoices;

        public string ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        
        public List<Invoice> Invoices
        {
        	get
        	{
        		return invoices;
        	}
        }

        public Customer(string id)
        {
            ID = id;
            invoices = new List<Invoice>();
        }
               
        public void AddInvoice(Invoice invoice)
        {
        	invoices.Add(invoice);
        }
    }
}
