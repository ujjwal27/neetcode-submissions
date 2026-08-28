public class MinStackObj {

    public MinStackObj(int val, int min)
    {
        this.stackValue = val;
        this.stackMinAtCurrent = min;
    }

    public int stackValue;
    public int stackMinAtCurrent;
}

public class MinStack {
    private Stack<MinStackObj> _stack;

    public MinStack() {
        _stack = new Stack<MinStackObj>();
    }
    
    public void Push(int val) {
        var _minValue = _stack.Any() ? Math.Min(this.GetMin(), val) : val;
        _stack.Push(new MinStackObj(val, _minValue));
    }
    
    public void Pop() {
        if (_stack.Any())
        {
            _stack.Pop();
        }
    }
    
    public int Top() {
        if (_stack.Any())
        {
            var obj = _stack.Peek();
            return obj.stackValue;  
        }  
        return 0;
    }
    
    public int GetMin() {
        if (_stack.Any())
        {
            var obj = _stack.Peek();
            return obj.stackMinAtCurrent;  
        }   
        return 0;
    }
}
