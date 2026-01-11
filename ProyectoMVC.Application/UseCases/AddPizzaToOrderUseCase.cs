using ProyectoMVC.Application.DTOs;
using ProyectoMVC.Application.Interfaces.Repositories;
using ProyectoMVC.Domain.Exceptions;

namespace ProyectoMVC.Application.UseCases;

public class AddPizzaToOrderUseCase
{
    private readonly IOrderRepository _orderRepository;
    private readonly IPizzaRepository _pizzaRepository;

    public AddPizzaToOrderUseCase(
        IOrderRepository orderRepository,
        IPizzaRepository pizzaRepository)
    {
        _orderRepository = orderRepository;
        _pizzaRepository = pizzaRepository;
    }

    public void Execute(AddPizzaToOrderDto dto)
    {
        var order = _orderRepository.GetById(dto.OrderId)
            ?? throw new DomainException("Pedido no encontrado");

        var pizza = _pizzaRepository.GetById(dto.PizzaId)
            ?? throw new DomainException("Pizza no encontrada");

        order.AddItem(pizza, dto.Quantity);

        _orderRepository.Save(order);
    }
}
