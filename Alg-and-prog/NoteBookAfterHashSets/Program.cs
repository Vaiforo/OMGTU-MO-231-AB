using System.Collections;

class Notebook {
    static void Main() {
        Queue<string> queue = Inputer.GetQueue();

        Dictionary<string, Dictionary<string, Call>> notebook = new();

        notebook = Creater.GetNoteBook(queue);
        
    }
}