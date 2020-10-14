namespace InvoiceTest
{
    
    public class Invoice{
        public string PartNumber{get; set;}
        public string PartDescription{get; set;}
        public int quantity;
        public decimal pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem){
            PartNumber = partNumber;
            PartDescription = partDescription;
            this.quantity = quantity;
            this.pricePerItem = pricePerItem;
        }

        public int GetQuantity()
        {
            return quantity;
        }
        
        
        public void SetQuantity(int quantity1){
            if(quantity1 > 0.0M){
            this.quantity = quantity1;
            }
        }

        public decimal GetPricePerItem()
        {
            return pricePerItem;
        }
        
        
        public void SetPricePerItem(decimal pricePerItem1){
            if(pricePerItem1 > 0.0M){
            this.pricePerItem = pricePerItem1;
            }
        }

        public void GetInvoiceAmount(){
            decimal result = quantity * pricePerItem;
            System.Console.WriteLine($"Invoice Amount is {result:C}");
        }
    }
}