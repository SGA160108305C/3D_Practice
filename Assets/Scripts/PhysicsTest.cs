using UnityEngine;
using System.Collections;
//무조건 컴포넌트가 존재하게 만든다.
[RequireComponent(typeof(Rigidbody))]
public class PhysicsTest : MonoBehaviour
{
    public float power = 100.0f;

    private Rigidbody rigid;

    // Use this for initialization
    void Awake()
    {
        //게임 오브젝트가 생성되는 순간 딱 한번 호출
        Debug.Log("Awake");
        rigid = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        //게임 오브젝트가 활성화 되는 순간 호출
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("Start");
        //게임 오브젝트의 Update함수가 실행되기전 호출

    }

    // Update is called once per frame
    void Update()
    {

    }

    //물리용 업데이트
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            rigid.AddForce(power, 0, 0);  //현재 상태에서 추가로
            //rigid.AddTorque(0, 100, 0);

            //rigid.MovePosition(new Vector3(3, 0, 0));     //특정 위치나 각도로 변경
            //rigid.MoveRotation(Quaternion.Euler(0, 120, 0));
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //충돌이 시작되었을때
        Debug.Log("충돌 시작 : " + other.gameObject.name);
    }

    public void OnCollisionStay(Collision other)
    {
        //충돌이 지속 중일때
        //Debug.Log("충돌 중 : " + other.collider.name);
    }

    public void OnCollisionExit(Collision other)
    {
        //충돌이 끝났을때
        Debug.Log("충돌 종료 : " + other.collider.name);
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 시작 : " + other.gameObject.name);
    }

    // OnTriggerStay is called once per frame for every Collider other that is touching the trigger
    public void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 접촉중 : " + other.gameObject.name);
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 종료 : " + other.gameObject.name);
    }
}
