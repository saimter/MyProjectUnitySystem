using System.Collections.Specialized;
using UnityEngine;

public class UsingObserver : MonoBehaviour
{
    delegate void NotifyHandler();
    NotifyHandler _notifyHandler;

    private void Start()
    {
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        _notifyHandler += new NotifyHandler(observer1.OnNotify);
        _notifyHandler += observer2.OnNotify;
    }
}
