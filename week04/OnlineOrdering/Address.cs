public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _postalCode;
    private string _country;

    /*
    method CreateAddress sets the full address
    */
    public void CreateAddress(string street, string city, string stateProvince, string postal, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _postalCode = postal;
        _country = country;
    }

    /*
    method InUSA returns a boolean if the country is USA
    */
    public Boolean InUSA()
    {
        bool countryIsUSA = false;

        if (_country == "USA")
        {
            countryIsUSA = true;
        }
        else if (_country == "United States")
        {
            countryIsUSA = true;
        }
        else if (_country == "USofA")
        {
            countryIsUSA = true;
        }
        else if (_country == "United States of America")
        {
            countryIsUSA = true;
        }
        else
        {
            countryIsUSA = false;
        }

        return countryIsUSA;
    }

    /*
    method returnAddress returns a string including the street, city, state/province, 
    postal code, and country with comma separators
    */
    public string ReturnAddress()
    {
        string addressString = _street + ", " + _city + ", " + _stateProvince + ", " + _postalCode;

        return addressString;
    }

    /*
    method returnStreet returns a string for the street
    */
    public string returnStreet()
    {
        return _street;
    }

    /*
    method returnCity returns a string for the city
    */
    public string returnCity()
    {
        return _city;
    }

    /*
    method returnProvince returns a string for the state/province
    */
    public string returnProvince()
    {
        return _stateProvince;
    }

    /*
    method returnPostalCode returns a string for the Postal Code
    */
    public string returnPostalCode()
    {
        return _postalCode;
    }

    /*
    method returnCountry returns a string for the country
    */
    public string returnCountry()
    {
        return _country;
    }

}