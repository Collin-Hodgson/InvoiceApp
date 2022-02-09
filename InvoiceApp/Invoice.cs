//A3-1: Classes
//Create an invoice app that a hardware store would use to represent and item sold at the store

namespace InvoiceApp
{
    public class Invoice
    {
        public string _partNumber { get; set; }
        public string _description { get; set; }
        private int _quantity;
        private decimal _price;

        public Invoice(string partNumber, string description, int quantity, decimal price)
        {
            _partNumber = partNumber;
            _description = description;
            _quantity = quantity;
            _price = price;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            } 
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }       
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0.0m)
                {
                    _price = value;
                } 
            }
        }

        public decimal GetInvoiceAmount()
        {
            return _price * _quantity;
        }

    }
}
