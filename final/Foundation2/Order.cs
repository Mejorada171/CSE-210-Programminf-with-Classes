class Order {
    private Product[] products;
    private Customer customer;
    private decimal shippingCost;
    private decimal totalPrice;

    public Order(Product[] products, Customer customer) {
        this.products = products;
        this.customer = customer;

        if (customer.IsInUSA()) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }

        totalPrice = shippingCost;

        foreach (Product product in products) {
            totalPrice += product.GetTotalPrice();
        }
    }

    public decimal GetTotalPrice() {
        return totalPrice;
    }

    public string GetPackingLabel() {
        string label = "";
        foreach (Product product in products) {
            label += $"{product.GetQuantity()}. {product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel() {
        string label = "";
        label += $"{customer.GetName()}\n";
        label += $"{customer.GetAddress().GetAddressString()}\n";
        return label;
    }
}