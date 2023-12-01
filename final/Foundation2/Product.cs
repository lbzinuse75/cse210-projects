public class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string productName, int productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int SubTotal()
    {
        return _price * _quantity;
    }

    public string ProductDisplay()
    {
        return $"Product ID: {_productId}  Product Name: {_productName}  Quantity: {_quantity}";
    }
}