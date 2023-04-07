using System;

class Product {
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity) {
        this._name = name;
        this._id = id;
        this._price = price;
        this._quantity = quantity;
    }

    public decimal GetTotalPrice() {
        return _price * _quantity;
    }

    public string GetName() {
        return _name;
    }

    public int GetId() {
        return _id;
    }

    public int GetQuantity() {
        return _quantity;
    }
}