public delegate void MyDelegate(int x, int y);

public class Publisher
{
    private MyDelegate myDelegate;
    // Step 1: Declare an event using the delegate type
    public event MyDelegate myEvent
    {
        add
        {
            myDelegate += value;
        }
        remove
        {
            myDelegate -= value;
        }
    }

    // Alternative way to declare the event without custom add/remove accessors
    //public event MyDelegate myEvent;

    public void RaiseEvent(int x, int y)
    {
        // Step 2: Raise the event
        this.myDelegate(x, y);
    }
}