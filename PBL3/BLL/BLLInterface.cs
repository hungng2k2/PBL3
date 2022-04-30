using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    interface BLLInterface<T>
    {
        List<T> GetAll();

        T GetById(string id);

        void checkAddUpdate(string id);

        void ExecuteAddUpdate(T t);

        void Delete(string id);
    }
}
