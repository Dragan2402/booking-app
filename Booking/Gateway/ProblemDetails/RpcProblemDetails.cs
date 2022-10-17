using Grpc.Core;

namespace Booking.Gateway.ProblemDetails;

public class RpcProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails
{
    public RpcProblemDetails(RpcException exception)
    {
        this.Type = string.Empty;
        this.Title = exception.Status.Detail;
        this.Status = HandleStatus(exception.StatusCode);
        this.Detail = exception.Message;
    }

    private int HandleStatus(StatusCode status)
    {
        switch (status)
        {
            case StatusCode.NotFound: return StatusCodes.Status404NotFound;
            case StatusCode.AlreadyExists: return StatusCodes.Status409Conflict;
            case StatusCode.InvalidArgument: return StatusCodes.Status400BadRequest;
            case StatusCode.FailedPrecondition: return StatusCodes.Status412PreconditionFailed;
            default: return StatusCodes.Status500InternalServerError;
        }
    }
}