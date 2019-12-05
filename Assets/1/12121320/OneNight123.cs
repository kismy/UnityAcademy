using UnityEngine;
using System.Collections;

public class OneNight123 : MonoBehaviour {


	void Start () {
        int i, j, k;
        int[] visit = new int[10];

        for (i = 123; i <= 329; i++)
        {
            for (int p = 0; p < visit.Length; p++) visit[p] = 0;

            visit[i / 100] = 1;  //给i的百位赋值
            int charNum = i / 10 % 10;  //取i的十位字符
            if (charNum!=0&&visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;
            charNum = i % 10;       //取i的个位字符
            if (charNum != 0&&visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;

            j = i * 2;
            charNum = j / 100;   //取j的百位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;
            charNum = j / 10 % 10; //取j的十位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;
            charNum = j % 10;       //取j的个位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;

            k = i * 3;
            charNum = k / 100;   //取k的百位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;
            charNum = k / 10 % 10; //取k的十位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;
            charNum = k % 10;       //取k的个位字符
            if (charNum != 0 && visit[charNum] == 0)
                visit[charNum] = 1;
            else continue;


            Debug.Log(k+"\t"+ j+"\t"+ i); //代码能够执行到这里说明i : j : k=1:2:3，且123456789都被用到了
        }
    }
	

}
