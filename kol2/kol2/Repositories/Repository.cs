using kol2.Context;
using kol2.Models;
using Microsoft.EntityFrameworkCore;

namespace kol2.Repositories;

public class RepositorySubscriptions : BaseRepository
{
    public RepositorySubscriptions(SubscriptionsContext dbConetext) : base(dbConetext)
    {
    }
    
    public Client GetAllClientsSubscriptions(int IdClient)
    {
        return _dbContext.Clients.FirstOrDefault(e => e.IdClient == IdClient);
    }
}