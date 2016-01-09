public class Queue {
    //For Stack,
    //Peek  is to get the last element
    //Pop   is to throw the last element
    //Push  is to add the last element
    
    //But for Queue,
    //Peek  is to get the tail element
    //Pop   is to throw the tail element
    //Push  is to add the head element
    
    //Use two stack to push and pop like a queue.
    //实际上数据是分开存储在output和input里面的
    //这个要说挺不好想的，记下来最好。
    
    Stack input = new Stack();
    Stack output = new Stack();
    
    // Push element x to the back of queue.
    public void Push(int x) {
        input.Push(x);
    }
    
    // Removes the element from front of queue.
    public void Pop() {
        Peek();
        output.Pop();
    }
    
    // Get the front element.
    public int Peek() {
        //First time user: Need to save element in reverse order to output stack
        if(output.Count == 0){
            while(input.Count != 0){
                output.Push(input.Pop());
            }
        }
        return (int)output.Peek();
    }
    
    // Return whether the queue is empty.
    public bool Empty() {
        if(input.Count == 0 && output.Count == 0)
            return true;
        else 
            return false;
    }
}
