namespace DesignAStack;

public class Stack
{

    Stack<object> NewStack = new Stack<object>(); 

    public void Push(object obj)
    {
       

        if (obj != null)
        {
            NewStack.Push(obj);
        }
        else
        {
            throw new InvalidOperationException("The object included in the Push() method is null.");
        }


        //store the object in stack.  
        //Need to upcast to the object class
        //Need to take into Account  null is passed to this object

        //if (var!= null)
        //{
        //   executethethingshere.
        //}
        // should not store nulls in the stack
    }


    public object Pop()
    {
        // removes the top object from the stack and and returns it
        // handle if stack is empty by throwing InvalidOperationException

        return NewStack.Pop();
    }

    public void Clear()
    {

        NewStack.Clear();

        
        //removes all objects from the stack 
    }
}