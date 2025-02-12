using UnityEngine;
using System.Collections.Generic;




public class UsingObserver2 : MonoBehaviour
{
    List<UObserver> observers = new List<UObserver>();
    public void Add(UObserver observer) 
    { 
    }
    void Remove(UObserver observer)
    { 
        if(observers.Count > 0)
        {
            observers.Remove(observer);
        }
    }
    void Notify()
    { 
        foreach(var observer in observers)
        {
            observer.OnNotify();
        }
    }
    void Start()
    {
        var observer1 = new Observer1();
        var observer2 = new Observer2();
    }
}
