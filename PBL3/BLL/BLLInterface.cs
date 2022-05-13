using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    interface BLLInterface<T>
    {
        dynamic GetAll();

        T GetById(string id);

        bool checkAddUpdate(string id);

        void ExecuteAddUpdate(T t);

        void Delete(string id);
    }
}
