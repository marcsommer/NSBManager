using Microsoft.Practices.Composite.Presentation.Events;
using NSBManager.UserInterface.PhysicalModule.Model;

namespace NSBManager.UserInterface.PhysicalModule.Events
{
    public class ServerChangedEvent : CompositePresentationEvent<Server>
    {
        public string SelectedServer { get; set; }
    }
}