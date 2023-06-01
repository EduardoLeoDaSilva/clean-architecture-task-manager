using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Communication.Mediator
{
    public class Publisher
    {
        private readonly IMediator _mediator;

        public Publisher(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Publish(EventMessage message)
        {
            await _mediator.Publish(message);
        }

        public async Task SendCommand(CommandMessage message)
        {
            await _mediator.Send(message);
        }
    }
}
