using Booking.Grpc.UserCottageContract.Requests.Cottages;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests;
[ProtoContract]
public class UpdateCottageRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public UpdateCottageCottageRequest CottageRequest { get; set; } = default!;
}