public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _productList = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    // public int SubTotal()
    // {
    //     return 0;
    // }

    public int OrderTotal()
    {
        int total = 0;
        // total price = sum of products plus a one-time shipping cost(US-$5, out of US $35)
        foreach(Product product in _productList)
        {
            total = total + product.SubTotal();
        }

            if(_customer.CountryUSA())
            {
                total = total + 5;
            }
            
            else
            {
                total = total + 35;
            }
        return total;
    }

    public void PackingLabel()
    {
        //name and product id of each product in order
        foreach(Product product in _productList)
        {
            Console.WriteLine(product.ProductDisplay());
        }
    }

    public string ShippingLabel()
    {
        // name and address of the customer
        return _customer.GetCustomerInfo();
    }
}