public class PurchaseOrder
{
    // orderID allows a customer to have multiple orders at the same time by assigning an orderID number
    private string _orderID;
    private List<ProductOrder> _productOrderList = new List<ProductOrder>();
    private Customer _customer;
    private double _shippingCost;

    /*
    method CreateOrder sets first part of an order with customer and the first selected product
    */
    public void CreateOrder(string orderNumber, Customer orderingCustomer, Product product, int quantity)
    {
        _orderID = orderNumber;
        _customer = orderingCustomer;
        ProductOrder productOrderItem = new ProductOrder(product, quantity);
        _productOrderList.Add(productOrderItem);
    }

    /*
    method AddToOrder selects an existing order and adds a new product to the order
    */
    public void AddToOrder(Product product, int quantity)
    {
        ProductOrder productOrderItem = new ProductOrder(product, quantity);
        _productOrderList.Add(productOrderItem);
    }

    /*
    method CalculateOrderCost returns the value of the entire order, 
    includes price perquantity from the products class and the shipping cost
    based on whether the mailing address is inside or outside the US
    */
    public double CalculateOrderCost()
    {
        double orderTotalWithShipping = 0;

        foreach (ProductOrder productOrderItem in _productOrderList)
        {
            orderTotalWithShipping += productOrderItem.PricePerQuantity();
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
        string packingListOnly = "";

        packingListWithAddress = _customer.MailingAddress + "\n" + "\n";

        foreach (ProductOrder product in _productOrderList)
        {
            packingListOnly += product.ReturnProductInfo() + "      ";
            for (int counter = 0; counter <= (50 - packingListOnly.Length); counter++)
            {
                packingListOnly += " ";
            }
            packingListOnly += product.ReturnQuantity + "\n";

        }
        packingListWithAddress += packingListOnly;
        return packingListWithAddress;
    }

    /*
    method SetShippingCost returns a shipping cost based on the location of the 
    customer - if they are inside or outside the US
    */
    public double SetShippingCost()
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