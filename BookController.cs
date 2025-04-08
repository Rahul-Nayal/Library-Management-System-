using System;
using Spectre.Console;

namespace TCSA.OOP.LibraryManagementSystem
{

    internal class BookController
    {

        private static List<string> books = new()
        {
            "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", "Catch-22", "The Hitchhiker's Guide to the Galaxy"
        };

        internal static void ViewBook()
        {
            AnsiConsole.MarkupLine("[yellow] List of Books :[/] ");
            foreach (string book in books)
            {
                AnsiConsole.MarkupLine($"[grey] {book} [/]");
            }
            AnsiConsole.MarkupLine("Press any key : ");
            Console.ReadKey();
        }

        internal static void AddBook()
        {
            var title = AnsiConsole.Ask<string>("Enter the title of the book to add : ");

            if (books.Contains(title))
            {
                AnsiConsole.MarkupLine("[red] Book is already exists[/]");
            }
            else
            {
                books.Add(title);
                AnsiConsole.MarkupLine("[green] Book added successfully [/]");
            }

            AnsiConsole.MarkupLine("Press any key to continue");
            Console.ReadKey();
        }

        internal static void DeleteBook()
        {
            if (books.Count == 0)
            {
                AnsiConsole.MarkupLine("[red] No book are available continue [/]");
            }
            var selectBook = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("Select a book to delete")
                        .AddChoices(books)
                    );
            if (books.Remove(selectBook))
            {
                AnsiConsole.MarkupLine("[green] Book deleted successfully [/]");
            }
            else
            {
                AnsiConsole.MarkupLine("[red] Book not found [/]");
            }

            AnsiConsole.MarkupLine("Press any key to continue : ");
            Console.ReadKey();
        }
    }
}

