using System.Collections.Generic;
using System.Data;

namespace PBL3.DAL
{
    interface DALInterface<T>
    {
        List<T> GetAll();

        T GetByDataRow(DataRow i);

        T GetById(string id);

        void Add(T t);

        void Update(T t);

        void Delete(string id);

    }
}
