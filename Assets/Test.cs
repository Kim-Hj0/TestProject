using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Transform transform;
    private Camera camera;
    private AudioListener audio;
    private GameObject go;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //for��.
        //int sum = 0; //������ �� �ʿ��ϴϱ�, �ϳ��� �������־�� ��. �޾��� �� �ִ�
        ////3���� 28������ ���� ���Ͻÿ�.
        //for (int i = 3; i <= 28; i++)   //�۰ų� ���� ��
        //{
        //    sum += i;
        //}
        //Debug.Log(sum); //3���� 28������ ���� ���ð���.


        //While������ ���ٸ�.
        //int i = 3;
        //int sum = 0;
        //while (i >=28)
        //{
        //    sum += i;
        //    i++;
        //}


        //foreach��
        int sum = 0;

        int[] arr = { 3, 5, 6, -2, 7, 10 };
        foreach (var element in arr)
        {
            sum += element; //�����ߴ� sum�� element(���ڵ�)�� �����ֱ�.
        }

        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        int count = 10;
        while (count >= 0)  //0�� �ɶ�����. 0���� Ŀ����.
        {
            Debug.Log(count);
            count--;
        }

        for(int c = 10; count >= 0; c--)
        {
            Debug.Log (c);
        }


        //transform = GetComponent<Transform>();
        //audioSource = GetComponentInChildren<AudioSource>();    //Update���� ���� �ȵ�. �׷��� ���� �ʱ�ȭ�� �� ��.
        //Debug.Log(transform.position.z);
        //DownVolume();
        //DownVolume();
    }

    // Update is called once per frame
    void DownVolume()
    {
        audioSource.volume -= 0.2f;
    }
}
