using System;
using System.Collections.ObjectModel;
using System.Linq;
using NSBManager.Infrastructure.EventAggregator;
using NSBManager.UserInterface.PhysicalModule.Events;
using NSBManager.UserInterface.PhysicalModule.Model;
using NSBManager.UserInterface.ViewModels;
using IEventAggregator=Microsoft.Practices.Composite.Events.IEventAggregator;

namespace NSBManager.UserInterface.PhysicalModule.ViewModels
{
    public class ServerDetailsViewModel : BaseViewModel, IListener<PhysicalModelChanged>
    {
        private readonly IPhysicalModel physicalModel;

        public ServerDetailsViewModel(IPhysicalModel physicalModel)
        {
            this.physicalModel = physicalModel;
        }

        public ObservableCollection<Endpoint> Endpoints
        {
            get { return GetEndpointsByServerFromPhysicalModel(); }
        }

        public string Filter { get; set; }

        private ObservableCollection<Endpoint> GetEndpointsByServerFromPhysicalModel()
        {
            var endpointsOnServer = new ObservableCollection<Endpoint>();

            var endpoints = physicalModel.Endpoints.Where(x => x.ServerName == Filter);

            foreach (var endpoint in endpoints)
            {
                endpointsOnServer.Add(endpoint);
            }
            return endpointsOnServer;
        }

        public void Handle(PhysicalModelChanged message)
        {
            
        }
    }
}