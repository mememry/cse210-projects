public class Product
{
    private string _productID;
    private string _productName;
    private double _price;

    /*
    constructors
    */
    public Product(string productID, string productName, double price)
    {
        this._productID = productID;
        this._productName = productName;
        this._price = price;
    }

    /*
    method CreateProduct sets all the qualities of the product except quantity, which is set at the time the order is placed
    */
    public void CreateProduct(string ID, string name, double price)
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
    method ReturnProductName returns the name of the product
    */
    public double ReturnProductPrice()
    {
        return _price;
    }

    public string ReturnProductInfo()
    {
        string productInfo = $"{_productID} {_productName} {_price}";
        return productInfo;
    }

}