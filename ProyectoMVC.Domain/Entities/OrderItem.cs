namespace ProyectoMVC.Domain.Entities;

public class OrderItem
{
    public Pizza Pizza { get; }
    public int Quantity { get; }
    public Money SubTotal => Pizza.Price * Quantity;

    public OrderItem(Pizza pizza, int quantity)
    {
        if (quantity <= 0)
            throw new DomainException("Cantidad inválida");

        Pizza = pizza;
        Quantity = quantity;
    }
}
