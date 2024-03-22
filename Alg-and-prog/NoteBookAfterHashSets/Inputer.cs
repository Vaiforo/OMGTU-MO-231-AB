public class Inputer {
    static public Queue<string> GetQueue() {
        Queue<string> queue = new();

        queue.Enqueue("3822 2828 21.03.2024 8");
        queue.Enqueue("3822 4141 22.03.2024 17");
        queue.Enqueue("3822 2828 22.03.2024 24");
        queue.Enqueue("3822 2828 22.03.2024 5");
        queue.Enqueue("3822 5555 23.03.2024 3");

        queue.Enqueue("4141 3822 20.03.2024 6");
        queue.Enqueue("4141 7777 21.03.2024 7");
        queue.Enqueue("4141 3822 21.03.2024 10");
        queue.Enqueue("4141 2828 22.03.2024 12");

        queue.Enqueue("5555 3822 21.03.2024 13");
        queue.Enqueue("5555 7777 22.03.2024 17");
        queue.Enqueue("5555 3822 22.03.2024 9");
        queue.Enqueue("5555 3822 23.03.2024 5");

        return queue;
    }
}