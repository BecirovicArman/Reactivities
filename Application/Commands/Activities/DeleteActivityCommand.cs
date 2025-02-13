using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Commands.Activities
{
    public record DeleteActivityCommand(Guid Id) : IRequest;
}