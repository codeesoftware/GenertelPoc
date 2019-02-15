using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenertelPoc.Service.Queries
{
    public class IsUniqueEmailQuery:IRequest<bool>
    {
        public string Email { get; set; }
    }
}
    