using ProyectoMVC.Domain.Entities;

namespace ProyectoMVC.Application.Interfaces.Repositories;

public interface IPizzaRepository
{
    Pizza? GetById(Guid id);
}
