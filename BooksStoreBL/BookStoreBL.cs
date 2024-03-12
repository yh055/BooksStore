using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;


namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> GetAllBooksPriceMore30()
        {
            return ListOfBooks.Where(x => x.Price > 30); 
        }
        public IEnumerable<BookDetails> GetAllBooksSort()
        {
            return ListOfBooks.OrderBy(x => x.Id);
        }
        public IEnumerable<int> GetAllBooksPriceOfComiks(/*List<BookDetails> l*/)
        {

            return /*(IEnumerable<BookDetails>)*/ListOfBooks.Where(c => c.IsComics == true).Select(p => p.Price);
        }
   
        public IEnumerable<string> GetAllBooksNameOf9()
        {

            return ListOfBooks.Where(c => c.MaxAge >= 9&& c.MinAge <= 9).Select(p => p.Name);
        }
     
    }
}
