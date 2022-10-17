using Booking.Services.Common.Domain;
using Microsoft.EntityFrameworkCore;

namespace Booking.Services.Common.Infrastructure;
public class UnitOfWork<TContext> : IUnitOfWork
    where TContext : DbContext
{
    private readonly TContext _context;

    public UnitOfWork(TContext context) => _context = context;

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default) =>
        await _context.SaveChangesAsync(cancellationToken);
}