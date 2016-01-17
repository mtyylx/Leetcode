
public class Queue {
    Stack<int> inStack = new Stack<int>();
    Stack<int> outStack = new Stack<int>();
    int count = 0;

    public void Push(int val)
    {
        inStack.Push(val);
        count++;
    }

    //Use outStack to dequeue element.
    //When outStack == empty, need to first copy everything from inStack to outStack, then pop from outStack.
    //When outStack != empty, just pop from outStack until outStack is empty.
    public int Pop()
    {
        count--;
        if (outStack.Count == 0) in2out();
        return outStack.Pop();
    }

    //The same as Dequeue, only difference is it does not delete the element.
    public int Peek()
    {
        if (outStack.Count == 0) in2out();
        return outStack.Peek();
    }

    public bool Empty()
    {
        return count == 0;
    }

    //Helper method, pour everything from inStack to outStack.
    private void in2out()
    {
        while(inStack.Count != 0) outStack.Push(inStack.Pop());
    }
}

