using System;
using UnityEngine;
using UnityEngine.UI;

//delegate를 이용하면 이벤트를 더 쉽게 할 수 있다.
class MeetEvent
{
    public delegate void MeetEventHandler(string message);
    public event MeetEventHandler meethandler;

    public void Meet()
    {
        meethandler("만난것도 인연인데 어디가서 차라도 한다...");
    }
}

public class UnityDelegateEentSample : MonoBehaviour
{
    public Text messageUI;
    MeetEvent meetEvent = new MeetEvent();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meetEvent.meethandler += EventMessage;
    }

    private void EventMessage(string message)
    {
        messageUI.text = message;
    }
    public void OnMeetButtonEnter(string message)
    {
        messageUI.text = message;
    }

    //  버튼에 반응한다.
    public void OnMeetButtonEvent()
    {
        meetEvent.Meet();
    }
    

}
