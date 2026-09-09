public class MyStack {

    private Queue<int> _q1;
    private Queue<int> _q2;

    public MyStack() {
        _q1 = new Queue<int>();
        _q2 = new Queue<int>();
    }

    // Push element x onto stack.
    // Time Complexity: O(N)
    public void Push(int x) {
        // Add new element to the empty queue
        _q2.Enqueue(x);

        // Push all remaining elements from _q1 to _q2
        while (_q1.Count > 0) {
            _q2.Enqueue(_q1.Dequeue());
        }

        // Swap the names of the queues so _q1 always holds the elements
        var temp = _q1;
        _q1 = _q2;
        _q2 = temp;
    }

    // Removes the element on top of the stack and returns it.
    // Time Complexity: O(1)
    public int Pop() {
        return _q1.Dequeue();
    }

    // Get the top element.
    // Time Complexity: O(1)
    public int Top() {
        return _q1.Peek();
    }

    // Returns whether the stack is empty.
    // Time Complexity: O(1)
    public bool Empty() {
        return _q1.Count() == 0;
    }


}

