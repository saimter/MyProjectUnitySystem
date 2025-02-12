using UnityEngine;
//  옵저버 패턴
//  한 오브제트의 상태가 변경이 되면 그 객체에 의존하고 이쓴ㄴ 다른 객체드에게 자동으로 내용이 갱신되는 설계방식

//  abstract class는 인터페이스처럼 메소드에 대한 선언을 진행 할 수 있는 클래스


/// <summary>
/// 옵저버에 대한 관리, 활용을 진행하기하기 위한 인터페이스
/// </summary>
public interface ISubject
{
    void Add(UObserver observer);       // 옵저버 등록
    void Remove(UObserver observer);    // 옵저버 제거
    void Notify();    // 옵저버 갱신

}


public abstract class UObserver
{
    public abstract void OnNotify();
}

public class Observer1 : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("UObserver action #1");
    }
}
public class Observer2 : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("UObserver action #2");
    }
}
