using LibriryConsole;

var lib = new Library();
while (true)
{

    Console.WriteLine("---------------Library---------------");
    Console.WriteLine("r - show all books");
    Console.WriteLine("c - add new book");
    Console.WriteLine("u - update book");
    Console.WriteLine("d - delete book");
    Console.WriteLine("f - find book by name");
    Console.WriteLine("a - find book by author");
    Console.WriteLine("e - exit");
    char com = char.Parse(Console.ReadLine());

    if (com == 'r')
    {
        foreach (var item in lib.GetBooks())
        {
            Console.WriteLine($"Id {item.Id} \nBook Title : {item.Name} \nBook author : {item.Author}");
            Console.WriteLine("-------------------------");
        }

        Console.ReadLine();
    }
    else if(com == 'c')
    {
        var bk = new Book();
        Console.WriteLine("Enter book Titile");
        bk.Name = Console.ReadLine();
        Console.WriteLine("Enter book Author");
        bk.Author = Console.ReadLine();
        lib.AddBook(bk);
        Console.WriteLine("Your book added on library");
        Console.ReadLine();
        
    }
    else if (com == 'u')
    {
        var bk = new Book();
        Console.WriteLine("Enter a book id: ");
        bk.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter new book Titile");
        bk.Name = Console.ReadLine();
        Console.WriteLine("Enter new book Author");
        bk.Author = Console.ReadLine();
        lib.UpdateBook(bk);
        Console.WriteLine("Book updated");
        Console.ReadLine();
    }
    else if (com == 'd')
    {
        Console.WriteLine("Enter a book id: ");
        int id = int.Parse(Console.ReadLine());
        lib.DeleteBook(id);
        Console.ReadLine();
    }
    else if (com == 'f')
    {
        Console.WriteLine("Enter a book Name:");
        var name = Console.ReadLine();
        lib.FindBookByName(name);
        Console.ReadLine();
    }
    else if (com == 'a')
    {
        Console.WriteLine("Enter a book Author:");
        var author = Console.ReadLine();
        lib.FindBookByAuthor(author);
        Console.ReadLine();
    }
    else if (com == 'e')
    {
        Console.ReadLine();
        break;
    }
    
}