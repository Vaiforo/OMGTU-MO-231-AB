using System;
using System.Collections;
using System.Security.Cryptography;

class Notebook {
    static void Main() {
        Queue<string> queue = Inputer.GetQueue();

        Dictionary<string, Dictionary<string, Call>> notebook = new();
        notebook = Creater.GetNoteBook(queue);

        int screenStatus = 0;
        while (true) {
            Console.Clear();
            switch (screenStatus) {
                case 0: {
                    Console.WriteLine("---NoteBook---\n");

                    Console.WriteLine("Выберите действие:");
                    
                    int top = Console.CursorTop;
                    int y = top;

                    Console.WriteLine("+ Номер на который чаще всего звонили по выбранному номеру");
                    Console.WriteLine("+ Номера с высоким временем сеанса общения по выбранному номеру");
                    Console.WriteLine("+ Выход");

                    int down = Console.CursorTop;

                    screenStatus = Choose(ref top, ref y, ref down) + 1;
                break; }
                
                case 1: {
                    Console.WriteLine("---Номер на который чаще всего звонили по выбранному номеру---\n");

                    Console.WriteLine("Выберите номер:");

                    int top = Console.CursorTop;
                    int y = top;

                    foreach (var (phoneNumber, _) in notebook)
                        Console.WriteLine($"+ {phoneNumber}");
                    
                    int down = Console.CursorTop;

                    string fromNumber = notebook.Keys.ToArray()[Choose(ref top, ref y, ref down)];

                    
                break; }

                case 3: {
                    Environment.Exit(0);
                break;}
            }
        }
    }

    static int Choose(ref int top, ref int y, ref int down) {
        Console.CursorTop = top;
        ConsoleKey key;
        while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter) {
            if (key == ConsoleKey.UpArrow) {
                if (y > top) {
                    y--;
                    Console.CursorTop = y;
                }
            }
            else if (key == ConsoleKey.DownArrow) {
                if (y < down - 1) {
                    y++;
                    Console.CursorTop = y;
                }
            }
        }

        Console.CursorTop = down;

        return y - top;
    }
}