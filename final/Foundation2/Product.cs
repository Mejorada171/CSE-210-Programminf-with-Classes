using System;

class Product {
    private string name;
    private int id;
    private decimal price;
    private int quantity;

    public Product(string name, int id, decimal price, int quantity) {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetTotalPrice() {
        return price * quantity;
    }

    public string GetName() {
        return name;
    }

    public int GetId() {
        return id;
    }

    public int GetQuantity() {
        return quantity;
    }
}