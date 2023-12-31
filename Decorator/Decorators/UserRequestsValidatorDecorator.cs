﻿using Decorator.Handlers;

namespace Decorator.Decorators;

public class UserRequestsValidatorDecorator : AbstractDecorator
{
    public UserRequestsValidatorDecorator(IUserRequestHandler userRequestHandler) 
        : base(userRequestHandler)
    {
    }

    public override Task HandleRequest(UserRequest request)
    {
        if (request.RequestedAt <= DateTime.Now.AddMinutes(-1))
        {
            throw new Exception($"User request {request.ContextId} is expired");
        }

        if (!request.IsAuthenticated)
        {
            throw new Exception($"User request {request.ContextId} was unauthenticated!");
        }
        
        return base.HandleRequest(request);
    }
}