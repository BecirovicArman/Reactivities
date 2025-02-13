using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;

namespace Application.Queries.Activities
{
    public record GetAllActivitiesQuery : IRequest<List<Activity>>;
}