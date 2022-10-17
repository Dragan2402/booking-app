using Booking.Services.Common.Exception;

namespace Booking.Services.Common.Data.Maybe;

public sealed class Maybe<T>
{
    private readonly T _item = default!;

    public Maybe() => HasItem = false;

    public Maybe(T? item)
    {
        if (item is null)
        {
            HasItem = false;
            return;
        }

        HasItem = true;
        _item = item;
    }

    public bool HasItem { get; }

    public bool HasNoItem => !this.HasItem;

    public T Item => this.HasItem ? _item : throw new EntityNotFoundException("Entity not found by requested parameteres.");
}
