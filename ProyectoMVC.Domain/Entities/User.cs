namespace ProyectoMVC.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    private readonly List<Order> _orders = new(); // Lista privada para almacenar las órdenes del usuario
    public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly(); // Exponer las órdenes como una colección de solo lectura

    public User(Guid id, string username, string email)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be null or empty.", nameof(username));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be null or empty.", nameof(email));

        Id = id;
        Username = username;
        Email = email;
    }

    public void AddOrder(Order order)
    {
        if (order == null)
            throw new ArgumentNullException(nameof(order), "Order cannot be null.");

        _orders.Add(order);
    }
}