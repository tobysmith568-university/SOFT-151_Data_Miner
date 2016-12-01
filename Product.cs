namespace DataMiner
{
    class Product
    {
        string stockCode;
        string description;
        float unitPrice;

        public string StockCode
        {
            get
            {
                return stockCode;
            }
            private set
            {
                stockCode = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                description = value;
            }
        }
        public float UnitPrice
        {
            get
            {
                return unitPrice;
            }
            private set
            {
                unitPrice = value;
            }
        }

        public Product(string stockCode, string description, float unitPrice)
        {
            StockCode = stockCode;
            Description = description;
            UnitPrice = unitPrice;
        }
    }
}