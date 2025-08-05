public class Customer
{
    private string _name;
    private Address _address;

    /*
    method inUSA returns true if customer's address is in the USA. Calls address's 
    inUSA method
    */
    public bool InUSA()
    {
        return _address.InUSA();
    }

    /*
    method returnShippingAddress returns a string including the customer name, street, city,
    state/province, postal code, and country with line separators to make a mailing label
    */
    public string ReturnShippingAddress()
    {
        string address;

        address = _name + "\n" + _address.returnStreet + "\n" + _address.returnCity + ", " + _address.returnProvince + " " + _address.returnPostalCode;

        return address;
    }

    /*
    method MailingAddress returns the address with the customer name as a string with comma separations
    */
    public string MailingAddress()
    {
        string address;

        address = _name + _address.ReturnAddress();

        return address;
    }
}