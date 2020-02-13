using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Domain
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person FindByName(string name);
        Person FindByVehicle(int idVehicle);
    }
}
