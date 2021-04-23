using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACLibros.Data;

namespace DACLibros.Admin
{
    public static class AdminAuthor
    {
        private static PubsContext context = new PubsContext();

        public static int Create(Author author)
        {
            context.Authors.Add(author); // agregamos el autor en memoria
            int Result = context.SaveChanges(); // guardamos en la base
            return Result;
        }

        public static int Edit(Author prmauthor)
        {
            Author author = context.Authors.Find(prmauthor.au_id);
            int Result = 0;
            if (author != null)
            {
                author.au_lname = prmauthor.au_lname;
                author.au_fname = prmauthor.au_fname;
                author.address = prmauthor.address;
                author.phone = prmauthor.phone;
                author.state = prmauthor.state;
                author.zip = prmauthor.zip;
                author.city = prmauthor.city;
                author.contract = prmauthor.contract;

                Result = context.SaveChanges();
            }

            return Result;
        }

        public static int Delete(Author prmauthor)
        {
            Author author = context.Authors.Find(prmauthor.au_id);
            int Result = 0;
            if (author != null)
            {
                context.Authors.Remove(author);//se marca en memoria para eliminar
                context.SaveChanges();//Guardar los cambios en la base

                Result = context.SaveChanges();
            }
            return Result;
        }

        public static List<Author> GetList()
        {
            return context.Authors.ToList();
        }


        public static List<Author> GetList(string city)
        {
            List<Author> authors = (from a in context.Authors
                                    where a.city == city
                                    select a).ToList();

            return authors;
        }

        public static Author GetByAuthor(string authorId)
        {
            Author author = (from a in context.Authors
                             where a.au_id == authorId
                             select a).Single();

            return author;
        }

    }
}
