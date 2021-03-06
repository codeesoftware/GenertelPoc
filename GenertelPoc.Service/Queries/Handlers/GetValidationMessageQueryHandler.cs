﻿using GenertelPoc.Common;
using GenertelPoc.Common.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Service.Queries.Handlers
{
    class GetValidationMessageQueryHandler : IRequestHandler<GetValidationMessageQuery, MessageViewModel>
    {
        public async Task<MessageViewModel> Handle(GetValidationMessageQuery request, CancellationToken cancellationToken)
        {
            var vm = new MessageViewModel {
                ValidationMessages = new Dictionary<string, string> {
                    { ValidationMessage.VAL_100,"Kérem, ezt a mezőt feltétlenül töltse ki!" },
                    { ValidationMessage.VAL_103,"Kérjük, adja meg  a teljes nevet!" },
                    { ValidationMessage.VAL_175,"Nem megfelelő korcsoport!" },
                    { ValidationMessage.VAL_206,"Az email cím formátuma hibás!" },
                    { ValidationMessage.VAL_300,"A két érték nem egyezik!" },
                    { ValidationMessage.VAL_301,"Ilyen e-mail cím már van!" },
                }
            };

            return await Task.FromResult(vm);
        }
    }
}
