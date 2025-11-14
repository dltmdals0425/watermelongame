using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Coroutine coroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  Debug.Log($"{Time.time}-3333");*/
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
                coroutine = StartCoroutine(coroutineTest(3.15f));//이렇게하면 한번만 코르틴이 생성된다.

                Invoke("printMess", 2f);//일정한 시간이 지난뒤 호출을해줌
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (coroutine != null)
                {
                    StopCoroutine(coroutine);
                }//한번만 눌러도 꺼짐
                /* StopCoroutine(coroutineTest());*/
                /* StopCoroutine("coroutineTest");*/
                //스탑코르틴은 한번만 눌러도 멈추게됨
                //메서드의 이름으로 등록하면 똑같은 이름으로 되어있는 모든 코르틴을 멈출수있다.
            }

        }
        void printMess()
        {
        }
        WaitForSeconds wfs = new WaitForSeconds(1.0f);//이렇게하면 하나의 객체를 반복적으로 사용하는거임1 추가적으로 계속만들지않는다.
        IEnumerator coroutineTest(float a)
        {

            yield return new WaitForSeconds(2f);


        }
    }
}
