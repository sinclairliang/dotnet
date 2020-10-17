using System.Collections.Generic;
using MediatR;
using Domain;
using System.Threading.Tasks;
using System.Threading;

namespace Application.Activities
{
    public class List 
    {
        public class Query : IRequest<List<Activity>>{}

        public class Handler:IRequestHandler<Query, List<Activity>>
        {
            public Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
    
}