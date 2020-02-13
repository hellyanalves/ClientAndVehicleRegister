using Register.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Register.DataAccess.Person
{
    public class PersonDAO : IPersonRepository
    {
        public void Delete(Domain.Person element)
        {
            throw new NotImplementedException();
        }

        public Domain.Person FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Domain.Person FindByVehicle(int idVehicle)
        {
            throw new NotImplementedException();
        }

        public Domain.Person GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Person> List()
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Person person)
        {
            throw new NotImplementedException();
        }
    }
}
