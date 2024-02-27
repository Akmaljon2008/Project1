using Dapper;
using Npgsql;

namespace LibriryConsole;

public class Library
{
     private string _connectionstring = 
          "Host=localhost;Port=5432;Database=LibraryDb;User id=postgres;password=akmaljon2008";

     public List<Book> GetBooks()
     {
          using var connect = new NpgsqlConnection(_connectionstring);
          return connect.Query<Book>("select * from books").ToList();
     }

     public void AddBook(Book book)
     {
          using var connect = new NpgsqlConnection(_connectionstring);
          connect.Execute("insert into books(name,author)values (@name,@author,@year)",book);
     }

     public void UpdateBook(Book book)
     {
          using var connect = new NpgsqlConnection(_connectionstring);
          connect.Execute("update books set name = @name,aythor=@author", book);
     }

     public void DeleteBook(int id)
     {
          using var connect = new NpgsqlConnection(_connectionstring);
          connect.Execute("deletem from books where id = @id", new { Id = id });
     }

     public void FindBookByName(string name)
     {
          using var connect = new NpgsqlConnection(_connectionstring); 
          var rez = connect.Query<Book>("select * from books where name = @name limit 1", new { Name = name }).ToList();

          foreach (var bk in rez)
          {
               Console.WriteLine($"Book Name{bk.Name} \nBook Author{bk.Author}");
          }
     }
     public void FindBookByAuthor(string author)
     {
          using var connect = new NpgsqlConnection(_connectionstring); 
          var rez = connect.Query<Book>("select * from books where author = @author limit 1", new { Author = author }).ToList();

          foreach (var bk in rez)
          {
               Console.WriteLine($"Book Name{bk.Name} \nBook Author{bk.Author}");
          }
     }
}