using UnityEngine;

// 유니티의 인터페이스(interface
// 공통적인 특징에 대한 관리 구현시 효과적입니다. 
//  함수 나 프로퍼티 등의 정의를 구현없이 진행 할 수 있도록 도와주는 기능
//  해당 인터페이스는 명시만 하기 때문에 사용하기 위해서는 반드시 상속을 통한 재구현으로 진행

public interface ICountAble
{
    //  int a = 0; 인터페이스 내에서는 이런식의 변수는 사용 할 수 없고 선언만 가능하다.
    int Count { get; set; }

    void CountPlus();
}

public interface IUserAble
{
    void Use();
}

//  인터페이스느 상속처럼 등록할 수 있습니다.
//  인터페이스의 경우 다중 상속이 가능합니다.
class Potion : ICountAble, IUserAble
{
    public int Count { get; set; }
    public string Name { get; set; }

    public void CountPlus()
    {

    }

    public void Use()
    {

    }
}
public class InterfaceSample : MonoBehaviour
{
    Potion potion = new Potion();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        potion.Count = 99;
        potion.Name = "빨간 포션";
        potion.CountPlus();
        potion.Use();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
