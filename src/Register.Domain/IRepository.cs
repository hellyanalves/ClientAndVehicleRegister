using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Domain
{
    public interface IRepository<T>
    {
        T GetById(int Id);
        void Save(T element);
        void Delete(T element);
        List<T> List();
    }
}
