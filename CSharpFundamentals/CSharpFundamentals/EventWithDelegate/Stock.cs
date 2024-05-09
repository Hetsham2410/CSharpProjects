using System;

public class Stock
{
    private string name;
    private decimal price;
    public string Name { get => this.name; }
    public decimal Price { get => this.price; set => this.price = value; }
    public Stock(string name)
    {
        this.name = name;
    }
    public delegate void PriceChangedHandler(Stock stockname, decimal oldPrice);
    public event PriceChangedHandler OnPriceChanged;
    public void ChangePriceBy(decimal percent)
    {
        decimal oldPrice = this.Price;
        this.Price += Math.Round(this.Price * percent, 2);
        if (OnPriceChanged != null)
            OnPriceChanged(this, oldPrice);

    }

}



