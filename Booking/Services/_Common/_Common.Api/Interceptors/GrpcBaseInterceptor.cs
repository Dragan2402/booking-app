using Booking.Services.Common.Exception;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System.Security.Authentication;

namespace Booking.Services.Common.Api.Interceptors;

public class GrpcBaseInterceptor : Interceptor
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await continuation(request, context);
        }
        catch (UseCaseBaseException ex)
        {
            switch (ex)
            {
                case EntityExistsException: throw new RpcException(new Status(StatusCode.AlreadyExists, ex.Message), ex.Message);
                case EntityNotFoundException: throw new RpcException(new Status(StatusCode.NotFound, ex.Message), ex.Message);
                case EmailNotUniqueException: throw new RpcException(new Status(StatusCode.AlreadyExists, ex.Message), ex.Message);
                case PasswordsNotMatchingException: throw new RpcException(new Status(StatusCode.InvalidArgument, ex.Message), ex.Message);
                case BusinessLogicException: throw new RpcException(new Status(StatusCode.FailedPrecondition,ex.Message),ex.Message);
                case InvalidCredentialsException: throw new RpcException(new Status(StatusCode.Unauthenticated, ex.Message), ex.Message);
                case TokenValidationException: throw new RpcException(new Status(StatusCode.Unauthenticated, ex.Message), ex.Message);
                default: throw new RpcException(new Status(StatusCode.Internal, ex.Message), ex.Message);
            }
           
        }
        catch (System.Exception ex)
        {
            throw new RpcException(new Status(StatusCode.Internal, ex.Message));
        }
    }
}