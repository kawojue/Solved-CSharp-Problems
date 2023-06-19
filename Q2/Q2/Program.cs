// Q2 — Queue

public class MyQueue<T>
{
    private T[] queueArray;
    private int front;
    private int rear;
    private int size;

    public MyQueue()
    {
        queueArray = new T[5];
        front = 0;
        rear = -1;
        size = 0;
    }
    public void Enqueue(T item)
    {
        if (size == 5)
        {
            Console.WriteLine("Queue is full. Cannot enqueue new item.");
            return;
        }

        rear = (rear + 1) % 5;
        queueArray[rear] = item;
        size++;
    }
    public T Peek()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty. Cannot peek.");
            return default(T);
        }

        return queueArray[front];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyQueue<int> myQueue = new MyQueue<int>();

        myQueue.Enqueue(5);
        myQueue.Enqueue(14);
        myQueue.Enqueue(15);
        myQueue.Enqueue(23);
        myQueue.Enqueue(32);

        int firstValue = myQueue.Peek();
        Console.WriteLine("First value in the queue: {0}", firstValue);
    }
}