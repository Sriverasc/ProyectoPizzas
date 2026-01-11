using ProyectoMVC.Application.DTOs;
using ProyectoMVC.Application.Interfaces.Repositories;
using ProyectoMVC.Domain.Exceptions;

namespace ProyectoMVC.Application.UseCases;

public class GetOrderUseCase
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderUseCase(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public OrderResultDto Execute(Guid orderId)
    {
        var order = _orderRepository.GetById(orderId)
            ?? throw new DomainException("Pedido no encontrado");

        return new OrderResultDto
        {
            OrderId = orderId,
            Total = order.Total.Amount
        };
    }
}
