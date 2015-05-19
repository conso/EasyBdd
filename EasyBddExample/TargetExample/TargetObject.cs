namespace EasyBddExample.TargetExample
{
    public class TargetObject
    {
        public int CustomerItems { get; private set; }
        public int Stock { get; private set; }

        public TargetObject()
        {
            CustomerItems = 0;
            Stock = 0;
        }

        public void CustomerBuy(int numberOfItems)
        {
            CustomerItems = CustomerItems + numberOfItems;
        }

        public void SetStock(int stockQuantity)
        {
            Stock = stockQuantity;
        }

        public void CustomerReturnItem()
        {
            CustomerItems --;
            Stock ++;
        }
        
    }
}
