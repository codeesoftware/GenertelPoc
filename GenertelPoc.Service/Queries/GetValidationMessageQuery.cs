﻿using GenertelPoc.Common.ViewModels;
using MediatR;

namespace GenertelPoc.Service.Queries
{
    public class GetValidationMessageQuery: IRequest<MessageViewModel>
    {
    }
}
