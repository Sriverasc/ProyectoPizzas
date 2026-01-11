namespace ProyectoMVC.Domain.Entities;

public class Order
{
    private readonly List<OrderItem> _items = new();
    public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

    public Money Total { get; private set; } = new Money(0);

    public void AddItem(Pizza pizza, int quantity)
    {
        var item = new OrderItem(pizza, quantity);
        _items.Add(item);
        Total += item.SubTotal;
    }
}
