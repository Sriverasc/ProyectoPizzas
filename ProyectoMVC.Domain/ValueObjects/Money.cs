namespace ProyectoMVC.Domain.ValueObjects;

public class Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        if (amount < 0)
            throw new DomainException("El monto no puede ser negativo");

        Amount = amount;
    }

    public static Money operator +(Money a, Money b) // Suma dos objetos Money
        => new Money(a.Amount + b.Amount);

    public static Money operator *(Money money, double quantity) // Multiplica el monto por una cantidad decimal
        => new Money(money.Amount * (decimal)quantity);
}   
