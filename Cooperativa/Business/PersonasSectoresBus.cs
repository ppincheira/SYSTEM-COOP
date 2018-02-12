using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class PersonasSectoresBus
    {

        public int PersonasSectoresAdd(PersonasSectores oPersonasSectores)
        {
            PersonasSectoresImpl oPersonasSectoresImpl = new PersonasSectoresImpl();
            return oPersonasSectoresImpl.PersonasSectoresAdd(oPersonasSectores);
        }

        public bool PersonasSectoresUpdate(PersonasSectores oPersonasSectores)
        {
            PersonasSectoresImpl oPersonasSectoresImpl = new PersonasSectoresImpl();
            return oPersonasSectoresImpl.PersonasSectoresUpdate(oPersonasSectores);
        }

        public bool PersonasSectoresDelete(int Id)
        {
            PersonasSectoresImpl oPersonasSectoresImpl = new PersonasSectoresImpl();
            return oPersonasSectoresImpl.PersonasSectoresDelete(Id);
        }

        public PersonasSectores PersonasSectoresGetById(int Id)
        {
            PersonasSectoresImpl oPersonasSectoresImpl = new PersonasSectoresImpl();
            return oPersonasSectoresImpl.PersonasSectoresGetById(Id);
        }

        public List<PersonasSectores> PersonasSectoresGetAll()
        {
            PersonasSectoresImpl oPersonasSectoresImpl = new PersonasSectoresImpl();
            return oPersonasSectoresImpl.PersonasSectoresGetAll();
        }
    }
}
