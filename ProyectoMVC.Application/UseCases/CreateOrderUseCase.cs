using ProyectoMVC.Application.DTOs;
using ProyectoMVC.Application.Interfaces.Repositories;
using ProyectoMVC.Domain.Entities;
using ProyectoMVC.Domain.Exceptions;

namespace ProyectoMVC.Application.UseCases;

public class CreateOrderUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IOrderRepository _orderRepository;

    public CreateOrderUseCase(
        IUserRepository userRepository,
        IOrderRepository orderRepository)
    {
        _userRepository = userRepository;
        _orderRepository = orderRepository;
    }

    public Guid Execute(CreateOrderDto dto)
    {
        var user = _userRepository.GetById(dto.UserId)
            ?? throw new DomainException("Usuario no encontrado");

        var order = new Order();
        user.AddOrder(order);

        _orderRepository.Save(order);

        return order.Id;
    }
}
