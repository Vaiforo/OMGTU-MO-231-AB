using System;
using System.Collections.Generic;

class Program {
    public static void Main() {
        Book[] books = new Book[10];

        books[0] = new Book("Стив", "Программирование на C++", 1997, new int[12] {0,0,0,0,1,1,1,0,1,1,1,1});
        books[1] = new Book("Олег", "Др-др-др", 2018, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
        books[2] = new Book("Олег", "Разгон Ryzen 7 3700x до 5 ГГц в домашних условиях", 2023, new int[12] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 });
        books[3] = new Book("Андрей", "Программирование на Go", 2022, new int[12] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 });
        books[4] = new Book("Роман", "Программирование на C#", 2022, new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
        books[5] = new Book("Андрей", "Хрыч", 2022, new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
        books[6] = new Book("Стив", "Программирование на C++", 1999, new int[12] { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 });
        books[7] = new Book("Чертила", "Программирование на Cher'те", 2022, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 });
        books[8] = new Book("Денис", "Создание Телеграм-бота для отметки посещаемости учениками высших учебных заведений занятий", 2023, new int[12] { 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1 });
        books[9] = new Book("Стив", "Программирование на C++", 2001, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 });

        string sortAuthor = "Стив";
        int sortYearofPublication = 2000;
        Book sortBook = books[2];

        foreach (Book book in books) {
            Console.WriteLine($"Книгу <<{book.getTitle()}>> выдававли за год: {book.getCountOfIssue()} раз");
        } Console.WriteLine("\n");

        Console.WriteLine("Сортировка по имени автора " + sortAuthor);
        foreach (Book book in Book.getBooksOfAuthor(books, sortAuthor)) Console.WriteLine(book.getBookInformation());

        Console.WriteLine("Сортировка по году издания, больше указанного " + sortYearofPublication);
        foreach (Book book in Book.getBooksOfYearAndMore(books, sortYearofPublication)) Console.WriteLine(book.getBookInformation());

        Console.WriteLine("Информация о книге <<Разгон Ryzen 7 3700x до 5 ГГц в домашних условиях>>" + sortBook.getBookInformation());
    }

    class Book {
        private string Author;
        private string Title;
        private int Year;
        private int[] DateOfIssue = new int[12];
        
        public Book(string Author, string Title, int Year, int[] DateOfIssue) {
            this.Author = Author;
            this.Title = Title;
            this.Year = Year;
            this.DateOfIssue = DateOfIssue;
        }

        public int getCountOfIssue() {
            int outCount = 0;
            foreach (int mounth in DateOfIssue) {
                if (mounth == 1) {
                    outCount++;
                }
            }
            return outCount;
        }

        public static Book[] getBooksOfYearAndMore(Book[] books, int year) {
            List<Book> outBooks = new List<Book>();
            foreach (Book book in books) {
                if (book.Year >= year) {
                    outBooks.Add(book);
                }
            }
            return outBooks.ToArray();
        }

        public static Book[] getBooksOfAuthor(Book[] books, string author) {
            List<Book> outBooks = new List<Book>();
            foreach (Book book in books) {
                if (book.Author == author) {
                    outBooks.Add(book);
                }
            }
            return outBooks.ToArray();
        }

        public string getBookInformation() {
            string datesOfIssue = getDateOfIssue();
            return $"Название книги: {Title}\nГод издания: {Year}\nАвтор: {Author}\n{datesOfIssue}";
        }

        public void setAuthor(String author) {
            this.Author = author;
        }

        public void setTitle(String title) {
            this.Title = title;
        }

        public void setYear(int year) {
            this.Year = year;
        }

        public void setDateOfIssue(int month, int type) {
            this.DateOfIssue[month] = type;
        }

        public string getAuthor() {
            return this.Author;
        }

        public string getTitle() {
            return this.Title;
        }

        public int getYear() {
            return this.Year;
        }

        public string getDateOfIssue() {
            string datesOfIssue = "\n";
            for (int i = 0; i < 12; i++) {
                if (DateOfIssue[i] == 1) {
                    datesOfIssue += $"в {i + 1} месяце;\n";
                }
            }

            return "Книга была выдана " + datesOfIssue;
        }
    }
}
