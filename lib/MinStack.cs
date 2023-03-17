namespace LeetCode;

public class MinStack {

    private Stack<int> _minSTack;
    private Stack<int> _stack;

    public MinStack() {

        _minSTack = new();
        _stack = new();

    }

    public void Push(int val) {

        _stack.Push(val);

        if (_minSTack.Count == 0 || val <= _minSTack.Peek()) {
            _minSTack.Push(val);
        }
    }

    public void Pop() {

        int val = _stack.Pop();
        if (val == _minSTack.Peek()) {
            _minSTack.Pop();
        }
    }

    public int Top() {
        return _stack.Peek();
    }

    public int GetMin() {
        return _minSTack.Peek();
    }
}