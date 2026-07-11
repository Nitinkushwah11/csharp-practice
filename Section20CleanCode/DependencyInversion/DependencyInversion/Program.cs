using System;

// Interface
interface IMessage
{
    void Send();
}

// Email implementation
class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

// SMS implementation
class SMS : IMessage
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}

// High-level class
class Notification
{
    private IMessage message;

    public Notification(IMessage message)
    {
        this.message = message;
    }

    public void Notify()
    {
        message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage email = new Email();
        Notification notification = new Notification(email);
        notification.Notify();

        Console.ReadKey();
    }
}
/*Switching to SMS

No changes are needed in the Notification class. Just create an SMS object.

IMessage sms = new SMS();
Notification notification = new Notification(sms);
notification.Notify();

Why does this follow DIP?
Notification depends on the IMessage interface, not on the Email or SMS classes.
You can easily add new message types (e.g., WhatsApp, PushNotification) without changing the Notification class.

*/
/*

using System.Reflection;

namespace DependencyInversion
{


    /*
    internal class Program
    {
        /*
            High-level modules should not depend on low - level modules.Both should depend on abstractions(interfaces).

            In simple words:

            Don't depend directly on a concrete class.
            Depend on an interface so you can easily replace one implementation with another
        */
/*
 * ❌ Without DIP (Violates the Principle)
      Here, the Notification class directly depends on Email.

using System;

class Email
{
public void Send()
{
    Console.WriteLine("Email Sent");
}
}

class Notification
{
private Email email = new Email();

public void Notify()
{
    email.Send();
}
}

class Program
{
static void Main()
{
    Notification notification = new Notification();
    notification.Notify();
}
}

*/
/*
static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
}
}
}

*/


