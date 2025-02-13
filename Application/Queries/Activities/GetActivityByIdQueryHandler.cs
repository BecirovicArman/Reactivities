using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Queries.Activities
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, Activity>
    {
        private readonly DataContext _context;
        public GetActivityByIdQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Activities.FindAsync(request.Id);
        }
    }
}