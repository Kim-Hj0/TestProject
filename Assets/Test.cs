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
        //for문.
        //int sum = 0; //더해줄 게 필요하니까, 하나를 선언해주어야 함. 받아줄 수 있는
        ////3부터 28까지의 합을 구하시오.
        //for (int i = 3; i <= 28; i++)   //작거나 같을 떄
        //{
        //    sum += i;
        //}
        //Debug.Log(sum); //3부터 28까지의 합이 나올거임.


        //While문으로 쓴다면.
        //int i = 3;
        //int sum = 0;
        //while (i >=28)
        //{
        //    sum += i;
        //    i++;
        //}


        //foreach문
        int sum = 0;

        int[] arr = { 3, 5, 6, -2, 7, 10 };
        foreach (var element in arr)
        {
            sum += element; //선언했던 sum에 element(숫자들)을 더해주기.
        }

        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        int count = 10;
        while (count >= 0)  //0이 될때까지. 0보다 커야함.
        {
            Debug.Log(count);
            count--;
        }

        for(int c = 10; count >= 0; c--)
        {
            Debug.Log (c);
        }


        //transform = GetComponent<Transform>();
        //audioSource = GetComponentInChildren<AudioSource>();    //Update에는 쓰면 안됨. 그래서 보통 초기화할 때 씀.
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
