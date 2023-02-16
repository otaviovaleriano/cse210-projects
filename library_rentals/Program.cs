// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Book book = new Book("Maze Runner", "978111111", 2345623);

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();
book.ShowBookDetails();

Dvd dvd = new Dvd ("2039203930", "Maze Runner");
dvd.ShowDvdDetails();

Magazine mag = new Magazine("Magazine Today", "First Edition", "13/02/2023");
mag.ShowMagazineDetails();