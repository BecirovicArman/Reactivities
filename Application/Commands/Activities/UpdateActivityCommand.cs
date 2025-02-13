using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;

namespace Application.Commands.Activities
{
    public record UpdateActivityCommand(Activity Activity) : IRequest;
}