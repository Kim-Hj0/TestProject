using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int w; //선언만 한 것.


    public int i = 5;   //선언하고 할당했다. 
    private int y = 2;
    protected int z = 3;

    int a = 1;

    int j = 567;
    float f = 2f;
    string s = "안녕";
    char c = 'a';
    bool b = true;

    int o; //선언했다(초기화) //0

    //바꾸려면 함수 안에서.{} 이 안에서.
    private void Start2()
    {
        i = 5; //할당했다 //5
        Test(); //이걸 작성하면 3.

        //Test();
        //i = 5;  일 경우는 5
        //순서에 따라 값이 다른 것.
    }

        void Test()
        {
            i = 3;
        }


        //초기화 - 1
        private void Awake()
        {
            Debug.Log("초기화 1");
        }


        // 초기화 - 2
        void Start()
        {
            Debug.Log("초기화 2");
        }

        //물리연산 끝나고 호출
        private void FixedUpdate()
        {

        }

        // 매 프레임(Frame)마다 호출, 시간 계산, 혹은 transform.position += 같은
        void Update()
        {

        }

        //위에 아이들 다 끝나고, 캐릭터를 움직인 후 카메라
        private void LateUpdate()
        {

        }

        //스크립트가 붙어있는 게임 오브젝트가 켜질 때.
        private void OnEnable()
        {
            Debug.Log("켜졌다.");
        }

        //스크립트가 붙어있는 게임 오브젝트가 꺼질 떄
        private void OnDisable()
        {
            Debug.Log("꺼졌다.");
        }
    
}

