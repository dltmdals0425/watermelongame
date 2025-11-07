using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Rendering.DebugUI;
enum Fruittype
{ 
    chrrey,
    perrsimmon,
    watermelon

};


public class objManager : MonoBehaviour
{
    [SerializeField] private GameObject[] frefabs;//범수님꺼 파쿠리
     private static readonly float INIT_POS = 4;
    private static readonly int Gravity_Scale = 1;
    public GameObject mainobj;
    private GameObject spawnobj;
    

    private void objmove()
    {
        Vector3 moupos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//카메라를 월드포인트로 고정
        moupos.z = 0f;
        moupos.y = spawnobj.transform.position.y;//y위치를 고정
        spawnobj.transform.position = moupos;//마우스의 위치를 받는다.
        if (moupos.x<-7.5f)//이것도 범수님꺼 파쿠리
        {

        }
    }
    private void objdrop() 
    {
        //마우스를 버튼을 떼면 떨어트리기
        spawnobj.GetComponent<Rigidbody2D>().gravityScale = Gravity_Scale;
        spawnobj = Instantiate(mainobj, new Vector3(8, INIT_POS, 0), Quaternion.identity);
        spawnobj.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    private void Start()
    {
        spawnobj = Instantiate(mainobj, new Vector3(8, INIT_POS, 0), Quaternion.identity);
        //Instantiate(생성될 오브젝트,위치값,회전값);
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            objmove();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            objdrop();
        }
    }
/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(gameObject.tag))
        {
            if ()
            {

            }
        }
    }*/
}

