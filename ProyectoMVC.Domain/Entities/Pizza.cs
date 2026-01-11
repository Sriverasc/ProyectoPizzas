namespace ProyectoMVC.Domain.Entities;

public class Pizza
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Money Price { get; private set; }

    public Pizza(Guid id, string name, Money price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainException("El nombre es obligatorio");

        Id = id;
        Name = name;
        Price = price;
    }
}
