using Clase.Models;
    
    namespace Clase.Repositories

{

    public interface IEventOrganizersAssociationRepository
    {
        List<EventOrganizerAssociation> GetAll();
        List<EventOrganizerAssociation> Get(int id);


        void CreateEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation);
        void UpdateEventOrganizersAssociation(int id, EventOrganizerAssociation eventOrganizerAssociation);
        void DeleteEventOrganizersAssociation(int id);

    }

    public class EventOrganizersAssociationRepository: IEventOrganizersAssociationRepository
    {
        public void CreateEventOrganizersAssociation(EventOrganizerAssociation eventOrganizerAssociation)
        {
            throw new NotImplementedException();
        }

        public void DeleteEventOrganizersAssociation(int id)
        {
            throw new NotImplementedException();
        }

        public List<EventOrganizerAssociation> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<EventOrganizerAssociation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEventOrganizersAssociation(int id, EventOrganizerAssociation eventOrganizerAssociation)
        {
            throw new NotImplementedException();
        }
    

    }
    
}
