
using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem;


//var menuChoices = new string[3] { "Add Book", "View Book", "Delete Book" };

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOptions>()
                        .Title("What do you want to do next")
                        .AddChoices(Enum.GetValues<MenuOptions>())
            );

            switch (choice)
            {
                case MenuOptions.ViewBook:
                    //AnsiConsole.MarkupLine("[yellow] List of Books: [/]");

                    //foreach(string book in books)
                    //{
                    //    AnsiConsole.MarkupLine($"[grey] {book} [/]");
                    //}
                    //AnsiConsole.MarkupLine("Press any key to continue");
                    //Console.ReadKey();
                    BookController.ViewBook();
                    break;


                case MenuOptions.AddBook:
                    //AnsiConsole.MarkupLine("[green] Add new book : [/]");
                    //var title = AnsiConsole.Ask<string>("Enter the [green] title[/] of the book to add : ");

                    //if (books.Contains(title))
                    //{
                    //    AnsiConsole.MarkupLine("[Red] This book is already exists.[/]");
                    //}
                    //else
                    //{
                    //    books.Add(title);
                    //    AnsiConsole.MarkupLine("[green] Book added successfully.[/]");
                    //}
                    //AnsiConsole.MarkupLine("Press any key to continue");
                    //Console.ReadKey();
                    BookController.AddBook();

                    break;

                case MenuOptions.DeleteBook:

                    //if(books.Count == 0)
                    //{
                    //    AnsiConsole.MarkupLine("[red] No books available to delete.[/]");
                    //    Console.ReadKey();
                    //    return;
                    //}

                    //var selectBook = AnsiConsole.Prompt(
                    //        new SelectionPrompt<string>()
                    //        .Title("Select book to delete")
                    //        .AddChoices(books)
                    //    );

                    //if (books.Remove(selectBook))
                    //{
                    //    AnsiConsole.MarkupLine("[green] Book deleted successfully.[/]");
                    //}
                    //else
                    //{
                    //    AnsiConsole.MarkupLine("[red] Book not found .[/]");
                    //}

                    BookController.DeleteBook();

                    //AnsiConsole.MarkupLine("Press any key to continue");
                    //Console.ReadKey();
                    break;



            }
        };

    }
}


enum MenuOptions
{
    ViewBook,
    AddBook,
    DeleteBook

};




//file I/O

//using System.IO;


//namespace file
//{
//    class FileOperation
//    {
//        public static void Main(string[] args)
//        {
//            try
//            {
//                //Console.WriteLine("Enter the content");
//                //string Content = Console.ReadLine();

//                //File.WriteAllText("fileName.txt", Content);

//                string readText = File.ReadAllText("fileName.txt");
//                Console.WriteLine(readText);
//                string sourcePath = @"/Users/rahulnayal/Documents/new.pages";
//                string destinationPath = @"/Users/rahulnayal/Documents/copied.pages";
//                File.Copy(sourcePath, destinationPath, true);
//                string readSourceContent = File.ReadAllText(sourcePath);
//                //Console.WriteLine(readSourceContent);
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine("Error : " + e.Message);
//            };
//        }
//    }
//}