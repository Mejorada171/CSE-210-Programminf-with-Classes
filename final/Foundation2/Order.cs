class Order {
    private Product[] _products;
    private Customer _customer;
    private decimal _shippingCost;
    private decimal _totalPrice;

    public Order(Product[] products, Customer customer) {
        this._products = products;
        this._customer = customer;

        if (_customer.IsInUSA()) {
            _shippingCost = 5;
        } else {
            _shippingCost = 35;
        }

        _totalPrice = _shippingCost;

        foreach (Product _product in products) {
            _totalPrice += _product.GetTotalPrice();
        }
    }

    public decimal GetTotalPrice() {
        return _totalPrice;
    }

    public string GetPackingLabel() {
        string label = "";
        foreach (Product product in _products) {
            label += $"{product.GetQuantity()}. {product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel() {
        string label = "";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetAddressString()}\n";
        return label;
    }
}