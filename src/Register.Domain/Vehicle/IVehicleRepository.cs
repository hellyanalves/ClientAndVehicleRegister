using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Domain
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle GetByPerson(int IdPerson);
    }
}
