using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericService<T>
    {
        void TInsert(T t);

    
        void TDelete(T t);

        void TUpdate(T T);

        List<T> TGetList();

        T TGetById(int id);
 

    }
   



    
}
