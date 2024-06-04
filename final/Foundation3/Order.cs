using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in this.products)
        {
            totalCost += product.GetTotalCost();
        }

        // Calculate shipping cost based on customer's location
        double shippingCost = this.customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (Product product in this.products)
        {
            packingLabel.AppendLine($"{product.GetName()} - {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return this.customer.GetName() + "\n" + this.customer.GetAddress();
    }
}
