public class Product
{
    private string _productID;
    private string _productName;
    private float _price;
    private int _quantity;

    /*
    method CreateProduct sets all the qualities of the product except quantity, which is set at the time the order is placed
    */
    public void CreateProduct(string ID, string name, float price)
    {
        _productID = ID;
        _productName = name;
        _price = price;
    }

    /*
    method ReturnProductID returns the product ID
    */
    public string ReturnProductID()
    {
        return _productID;
    }

    /*
    method ReturnProductName returns the name of the product
    */
    public string ReturnProductName()
    {
        return _productName;
    }

    /*
    method PricePerQuantity takes the quantity from an order and returns the price 
    multiplied by the given quantity
    */
    public float PricePerQuantity()
    {
        float priceTimesQuantity = 0;

        priceTimesQuantity = _price * _quantity;

        return priceTimesQuantity;
    }

    /*
    method ReturnQuantity returns the quantity ordered
    */
    public int ReturnQuantity()
    {
        return _quantity;
    }
}