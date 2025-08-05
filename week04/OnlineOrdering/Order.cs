public class PurchaseOrder
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private float _shippingCost;

    /*
    method CalculateOrderCost returns the value of the entire order, 
    includes price perquantity from the products class and the shipping cost
    based on whether the mailing address is inside or outside the US
    */
    public float CalculateOrderCost()
    {
        float orderTotalWithShipping = 0;

        foreach (Product product in _productList)
        {
            orderTotalWithShipping += product.PricePerQuantity();
        }
        if (_customer.InUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        orderTotalWithShipping += _shippingCost;

        return orderTotalWithShipping;
    }

    /*
    method ShippingLabel returns the shipping address with the customer name
    and address
    */
    public string ShippingLabel()
    {
        return _customer.ReturnShippingAddress();
    }

    /*
    method Packing Label includes the customer name, shipping address, and 
    the packing list - list of products and quantities
    */
    public string PackingLabel()
    {
        string packingListWithAddress = "";

        packingListWithAddress = _customer.MailingAddress + "\n";

        foreach (Product product in _productList)
        {
            packingListWithAddress += product.ReturnProductID + "      " + product.ReturnProductName + "    " + product.ReturnQuantity;

        }

        return packingListWithAddress;
    }

    /*
    method SetShippingCost returns a shipping cost based on the location of the 
    customer - if they are inside or outside the US
    */
    public float SetShippingCost()
    {
        if (_customer.InUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        return _shippingCost;
    }

}