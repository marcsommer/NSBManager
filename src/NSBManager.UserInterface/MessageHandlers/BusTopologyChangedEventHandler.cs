using System.Linq;
using NSBManager.ManagementService.Messages;
using NSBManager.UserInterface.Models;
using NServiceBus;
using Endpoint=NSBManager.UserInterface.Models.Endpoint;

namespace NSBManager.UserInterface.MessageHandlers
{
    public class BusTopologyChangedEventHandler : IHandleMessages<BusTopologyChangedEvent>
    {
        private readonly IPhysicalModel physicalModel;

        public BusTopologyChangedEventHandler(IPhysicalModel physicalModel)
        {
            this.physicalModel = physicalModel;
        }

        public void Handle(BusTopologyChangedEvent message)
        {
            physicalModel.UpdateModel(message.Endpoints.Select(x => new Endpoint
                                                                       {
                                                                           //todo: add endpoint name here
                                                                           Name = x.Id.ToString()
                                                                       }));
        }
    }
}