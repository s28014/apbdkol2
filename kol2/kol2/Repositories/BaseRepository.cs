using kol2.Context;
using kol2.Models;

namespace kol2.Repositories;

public class BaseRepository
{
    protected readonly SubscriptionsContext _dbContext;

    protected BaseRepository(SubscriptionsContext dbContext)
    {
        _dbContext = dbContext;
    }
}