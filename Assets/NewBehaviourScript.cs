using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int w; //���� �� ��.


    public int i = 5;   //�����ϰ� �Ҵ��ߴ�. 
    private int y = 2;
    protected int z = 3;

    int a = 1;

    int j = 567;
    float f = 2f;
    string s = "�ȳ�";
    char c = 'a';
    bool b = true;

    int o; //�����ߴ�(�ʱ�ȭ) //0

    //�ٲٷ��� �Լ� �ȿ���.{} �� �ȿ���.
    private void Start2()
    {
        i = 5; //�Ҵ��ߴ� //5
        Test(); //�̰� �ۼ��ϸ� 3.

        //Test();
        //i = 5;  �� ���� 5
        //������ ���� ���� �ٸ� ��.
    }

        void Test()
        {
            i = 3;
        }


        //�ʱ�ȭ - 1
        private void Awake()
        {
            Debug.Log("�ʱ�ȭ 1");
        }


        // �ʱ�ȭ - 2
        void Start()
        {
            Debug.Log("�ʱ�ȭ 2");
        }

        //�������� ������ ȣ��
        private void FixedUpdate()
        {

        }

        // �� ������(Frame)���� ȣ��, �ð� ���, Ȥ�� transform.position += ����
        void Update()
        {

        }

        //���� ���̵� �� ������, ĳ���͸� ������ �� ī�޶�
        private void LateUpdate()
        {

        }

        //��ũ��Ʈ�� �پ��ִ� ���� ������Ʈ�� ���� ��.
        private void OnEnable()
        {
            Debug.Log("������.");
        }

        //��ũ��Ʈ�� �پ��ִ� ���� ������Ʈ�� ���� ��
        private void OnDisable()
        {
            Debug.Log("������.");
        }
    
}

