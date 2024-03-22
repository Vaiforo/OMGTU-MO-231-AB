public class Inputer {
    static public Queue<string> GetQueue() {
        Queue<string> queue = new();
        queue.Enqueue("3822 2828 21.03.2024");
        queue.Enqueue("3822 4141 22.03.2024");
        queue.Enqueue("3822 2828 22.03.2024");
        queue.Enqueue("3822 2828 22.03.2024");
        queue.Enqueue("3822 5555 23.03.2024");

        queue.Enqueue("4141 3822 21.03.2024");
        queue.Enqueue("4141 7777 20.03.2024");
    }
}