namespace MyFirstCrudAPI_Net8.Services;

public class IContaRepository
{
    private readonly IContaRepository _contaRepository;

    public IContaRepository(IContaRepository contaRepository)
    {
        _contaRepository = contaRepository ?? throw new ArgumentNullException(nameof(contaRepository));
    }
}