using UnityEngine;
using System.Collections;
using System.Threading;

public class Coroutine : MonoBehaviour {


    void Start()
    {
        StartCoroutine(tt());//开启协程
        for (int i = 0; i < 200; i++)   //循环A
        {
            Debug.Log("循环A...ing" + i);
            Thread.Sleep(10);
        }
    }


    IEnumerator tt()
    {
        for (int i = 0; i < 100; i++) //循环B
        {
            Debug.Log("循环B...ing" + i);
        }

        yield return new WaitForSeconds(1); //协程1

        for (int i = 0; i < 100; i++) //循环C
        {
            Debug.Log("循环C...ing" + i);
            yield return null; //协程1
        }
    }

    // 更新数据
    void Update()
    {
        Debug.Log("Update");
    }

    //晚于更新
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

}
