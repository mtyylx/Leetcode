public class Stack {
    Queue<int> queue = new Queue<int>();
    
    //核心思想是每次Enqueue后，除了刚加进来的元素，循环把队列其他元素先出队再入队。
    public void Push(int x) {
        queue.Enqueue(x);
        for(int i = 0; i < queue.Count - 1; i++)
            queue.Enqueue(queue.Dequeue());
    }

    // Removes the element on top of the stack.
    public int Pop() {
        return queue.Dequeue();
    }

    // Get the top element.
    public int Top() {
        return queue.Peek();
    }

    // Return whether the stack is empty.
    public bool Empty() {
        return queue.Count == 0;
    }
}