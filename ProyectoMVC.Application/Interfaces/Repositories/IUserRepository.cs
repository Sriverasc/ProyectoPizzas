using ProyectoMVC.Domain.Entities;

namespace ProyectoMVC.Application.Interfaces.Repositories;

public interface IUserRepository
{
    User? GetById(Guid id);
}
