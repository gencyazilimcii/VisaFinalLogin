using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class //Dışardan bir T değeri alır ve bu T mutlaka class olmalıdır
    {
        void Insert(T t);
        void Delete(T t);   
        void Update(T t);
        T GetByID(int id);

        void VizeFinalHesapla();

        List<T> GetList(); //Listeyi getir


    }
}
