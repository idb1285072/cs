# Event

## What?

- Event is a multi-cast delegate that stores one or more methods; and invoke them every time when the event is raised (called)
- The event can be raised only in the same class, in which it is created.

## Publisher vs Subscriber

- Events enable class to send notifications to other classes, when something occurs
- Publisher class sends events; Subscriber class receives events.

## Process Flow of Events

- The publisher class creates an event
- The subscriber class subscribes to the event; that means an event handler method is created in the subscriber class. The event handler method is nothing but, the method which is dedicated to be executed when the event is raised
- The publisher class can send (raise) events
- Every time, when the event is raised by the publisher, the corresponding event handler method executes automatically

## Steps for creating events

```cs
// Create a delegate
publish delegate ReturnType DelegateTypeName(param1, param2, ...);

// Create an event in PUblisher Class
class Publisher
{
  private DelegateTypeName eventVariable;
  public event DelegateTypeName EventName
  {
    add
    {
      eventVariable += value;
    }
    remove
    {
      eventVariable -= value;
    }
  }
}

// Raise the event in Publisher Class
if(EventName != null) EventName(arg1, arg2, ...);

// Create Event Handler Method in Subscriber Class
class Subscriber
{
  public ReturnType EventHandlerMethodName(param1, param2, ...)
  {
    // method body here
  }
}

// Subscribe to the Event (Inside or Outside the subscriber class)
EventName += EventHandlerMethodName;
```

## Rule

- The event should be created based on the delegate. That means, the event accepts the methods that are having specific parameters and return type, defined in the delegate
- An event can have multiple subscriber
- A subscriber can subscribe multiple events from multiple publishers
- Events are basically signals to inform to other classes, that some important thing happened in the publisher class
- Events are special kind of multi-cast delegates, which can raised only within the same class, in which they are created
- Events can be static, virtual, sealed and abstract
- Events will not be raised (throws exception), if there is no at least one subscriber.
- Events can be defined in interfaces
- It's not a good idea to return value in events
