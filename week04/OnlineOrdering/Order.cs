public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public double GetOrderTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.IsUsResident())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return Math.Round(totalCost, 2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Product Name - Product Id\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} - Address: {_customer.GetAddress().GetAddress()}";
    }
}