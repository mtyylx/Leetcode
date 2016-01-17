
public class Queue {
    Stack<int> inStack = new Stack<int>();
    Stack<int> outStack = new Stack<int>();
    int count = 0;

	//用双栈实现队列
    //看到一个队列，就好比银行柜台排队的队列，且你的视角就是坐在窗户里面的银行职员
    //Enqueue：来了一个新的顾客，肯定是排在队尾等着，否则就成加塞儿了。
    //Dequeue：你搞定了一个顾客，这个顾客肯定是队首的顾客，既然完事了那么走的肯定是他了
    //Peek：你纳闷还有多少人排着队于是就抬头看了下，只看到了队首第一个坐在你面前的这位
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

