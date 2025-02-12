using UnityEngine;
using UnityEngine.EventSystems;

//유니티에서 제공해주는 Eent, IPoint
//Ipoint Interface
//	Unity의 EventSystems에서 기본적으로 제공되는 인터페이스 입니다.
//	사용하기 위해서는 다음과 같은 조건이 필요합니다.

// 클릭, 터치, 드래그 등의 이벤트를 구현할 때 사용

//  1. UI 오브젝트에는 Graphic Raycaster 컴포넌트가 추가 되어있어야 한다.
//  추가적으로 Raycast Target이 체크가 된 상태여야 합니다.

//  2. Scene에는 EventSystem 컴포넌트가 존재해야 합니다.

//  3. 오브젝트에 대한 작업시에는 Collider 컴포넌트가 추가 되어있어야 한다.

//  4. MainCamera에 Physics Raycaster 컴포넌트가 추가되어야 합니다.


public class UInterSample : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //  클릭할때 실행할 함수
        Debug.Log("클릭을 진행했습니다.");

    }

    //  사용 방법
    //  1. 이 기능을 사용할 오브젝트에 연결
    //  2. 씬에 Event System 오브젝트를 배치
    //  만약 씬에 캔버스 생성을 진행했다면, 자동으로 배치가 되며 아닌 경우면 따로 만들어 연결
    //  3. 오브젝트에 콜라이더를 연결
    //  4. 카메라에 Physics RayCaster 컴포넌트를 연결
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // IPointerClickHandler
    //  해당 I를 추가하면 마우스를 클릭 또는 터치할 때 한번만 호추되는 이벤트
    //  누르고 뗏을 경우 호출

    //IPointerDownHandler
    //누르는 순간에 호출되는 마우스 클릭/터치 이벤트

    //IPointerUpHandler

    //IPointerDragHandler


    //IPointerDownHandler
    // https://docs.unity3d.com/kr/530/Manual/SupportedEvents.html
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
