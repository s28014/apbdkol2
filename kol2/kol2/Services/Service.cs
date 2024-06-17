using kol2.Repositories;

namespace kol2.Services;

public class Service
{
    protected readonly Repository _repository;
    public Service(Repository repository)
    {
        _repository = repository;
    }
    
}