//A3-1: Classes
//Create an invoice app that a hardware store would use to represent and item sold at the store

namespace InvoiceApp
{
    public class Invoice
    {
        private string _partNumber;
        private string _description;
        private int _quantity;
        private decimal _price;

        public Invoice(string partNumber, string description, int quantity, decimal price)
        {
            _partNumber = partNumber;
            _description = description;
            _quantity = quantity;
            _price = price;
        }

        public string GetPartNumber()
        {
            return _partNumber;
        }

        public void SetPartNumber(string partNumber)
        {
            _partNumber = partNumber;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            if (quantity > 0)
            {
                _quantity = quantity;
            }
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            if(price > 0)
            {
                _price = price;
            }

        }

    }
}
