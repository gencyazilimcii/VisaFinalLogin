using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Delete(T t)
        {
            using var context = new Context();  //Context sınıfından bir nesne örneği aldım
            context.Set<T>().Remove(t); //Yukardan gelen t ye göre sen bunu ayarla ve t ye göre sil
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new Context();  
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new Context();
            context.Set<T>().Add(t);
            context.SaveChanges();  
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }

        public void VizeFinalHesapla()
        {
            using var context = new Context();

            var vize1Property = typeof(T).GetProperty("Vize1");
            var vize2Property = typeof(T).GetProperty("Vize2");
            var finalProperty = typeof(T).GetProperty("Final");

            var entities = context.Set<T>().ToList();

            foreach (var entity in entities)
            {
                var vize1 = (double)vize1Property.GetValue(entity);
                var vize2 = (double)vize2Property.GetValue(entity);
                var final = (double)finalProperty.GetValue(entity);

                var ortalama = (vize1 + vize2 + final) / 3;

                if (ortalama < 60 || final < 60)
                {
                    // Ortalama 60'dan düşükse veya final puanı 60'dan düşükse, işleme devam etme
                    continue;
                }

                // Hesaplama sonucunu kullanarak gerekli işlemleri yapabilirsiniz
                // Örneğin, notları kaydedebilir veya başka bir işlem gerçekleştirebilirsiniz

                // Örnek olarak, ortalama değerini bir özellik olarak güncelleyelim:
                var ortalamaProperty = typeof(T).GetProperty("Ortalama");
                ortalamaProperty.SetValue(entity, ortalama);

                context.Set<T>().Update(entity);
            }

            context.SaveChanges();
        }
    }
}
