namespace ProyectoMVC.Application.DTOs;

public class AddPizzaToOrderDto
{
    public Guid OrderId { get; set; }
    public Guid PizzaId { get; set; }
    public int Quantity { get; set; }
}
