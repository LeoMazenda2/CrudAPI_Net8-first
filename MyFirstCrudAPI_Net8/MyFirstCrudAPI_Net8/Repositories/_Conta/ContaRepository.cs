using MyFirstCrudAPI_Net8.Context;
using MyFirstCrudAPI_Net8.Models;
using MyFirstCrudAPI_Net8.Repositories.Generics;

namespace MyFirstCrudAPI_Net8.Repositories;

public class ContaRepository : GenericRepository<Conta>, IContaRepository
{
    public ContaRepository(AppDbContext context) : base(context) { }
}