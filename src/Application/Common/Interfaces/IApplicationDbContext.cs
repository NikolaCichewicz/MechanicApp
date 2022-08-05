using Microsoft.EntityFrameworkCore;

namespace MechanicApp.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
