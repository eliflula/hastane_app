using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IBusiness<T>
    {
        bool Add(T instance);
        bool Delete(T instance);
        bool Update(T instance);
        List<T> getList();
    }
}
