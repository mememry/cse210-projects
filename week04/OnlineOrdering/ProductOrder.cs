public class ProductOrder
{
    private Product _product;
    private int _quantity;

    /*
    constructor
    */
    public ProductOrder(Product product, int quantity)
    {
        this._product = product;
        this._quantity = quantity;
    }

    /*
    method ReturnQuantity returns the quantity ordered
    */
    public int ReturnQuantity()
    {
        return _quantity;
    }

    /*
    method PricePerQuantity takes the quantity from an order and returns the price 
    multiplied by the given quantity
    */
    public double PricePerQuantity()
    {
        double priceTimesQuantity = 0;

        priceTimesQuantity = _product.ReturnProductPrice() * _quantity;

        return priceTimesQuantity;
    }

    public string ReturnProductInfo()
    {
        string productInfo = $"{_product.ReturnProductID} {_product.ReturnProductName}";
        return productInfo;
    }

}
