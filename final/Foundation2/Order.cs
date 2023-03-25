public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += "Product Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Customer Name: " + _customer.GetName() + ", Customer Address: " + _customer.GetAddress().GetFullAddress();
    }
}
