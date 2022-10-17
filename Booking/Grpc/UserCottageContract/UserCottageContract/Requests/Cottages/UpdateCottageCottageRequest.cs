using Booking.Grpc._Common.Grpc.Requests;
using ProtoBuf;

namespace Booking.Grpc.UserCottageContract.Requests.Cottages;

[ProtoContract]
public class UpdateCottageCottageRequest
{
    [ProtoMember(1)]
    public string Name { get; set; } = string.Empty;

    [ProtoMember(2)]
    public AddressRequest Address { get; set; } = default!;
}