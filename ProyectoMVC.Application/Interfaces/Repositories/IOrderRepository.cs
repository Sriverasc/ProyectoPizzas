using ProyectoMVC.Domain.Entities;

namespace ProyectoMVC.Application.Interfaces.Repositories;

public interface IOrderRepository
{
    Order? GetById(Guid id);
    void Save(Order order);
}
