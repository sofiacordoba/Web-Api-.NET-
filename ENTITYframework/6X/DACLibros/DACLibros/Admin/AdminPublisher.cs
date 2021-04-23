using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACLibros.Data;


namespace DACLibros.Admin
{
    public static class AdminPublisher
    {
        private static PubsContext context = new PubsContext();

        public static int Create(Publisher publisher)
        {
            context.Publishers.Add(publisher); // agregamos el publisher en memoria
            int Result = context.SaveChanges(); // guardamos en la base
            return Result;
        }

        public static int Edit(Publisher prmpublisher)
        {
            Publisher publisher = context.Publishers.Find(prmpublisher.pub_id);
            int Result = 0;
            if (publisher != null)
            {
                publisher.pub_name = prmpublisher.pub_name;
                publisher.city = prmpublisher.city;
                publisher.state = prmpublisher.state;
                publisher.country = prmpublisher.country;


                Result = context.SaveChanges();
            }

            return Result;
        }

        public static int Delete(Publisher prmpublisher)
        {
            Publisher publisher = context.Publishers.Find(prmpublisher.pub_id);
            int Result = 0;
            if (publisher != null)
            {
                context.Publishers.Remove(publisher);//se marca en memoria para eliminar
                context.SaveChanges();//Guardar los cambios en la base

                Result = context.SaveChanges();
            }
            return Result;
        }

        public static List<Publisher> GetList()
        {
            return context.Publishers.ToList();
        }

        public static List<Publisher> GetList(string country)
        {
            List<Publisher> publishers = (from e in context.Publishers
                                    where e.country == country
                                    select e).ToList();

            return publishers;
        }

        public static Publisher GetbyPublisher(string publisherId)
        {
            Publisher publisher = (from e in context.Publishers
                             where e.pub_id == publisherId
                                   select e).Single();

            return publisher;
        }
    }

}

