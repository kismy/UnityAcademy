using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//引用类型
class RefData
{
    public Int32 a;
}
//值类型
struct ValData
{
    public Int32 a;
}
public class ValueVSRefrence : MonoBehaviour
{

   

    void Start () {
     //   string s1 = "a";
     //   string s2 = s1;
     //   s1 = "b";//s2 is still "a"
     //   print(s2);

     //   String V1="a";
     //   String V2 = V1;
	 //   V1 = "b";//V2 is still "a"
     //   print(s2);

     //   //改变s1的值对s2没有影响。
     //   //这更使string看起来像值类型
     //   //实际上，这是运算符重载的结果，当s1被改变时，.NET在托管堆上为s1重新分配了内存。  s1 = "123"s1=new string("123")的简写，它的每一次赋值都会抛掉原来的对象而生成一个新的字符串对象，分配新的内存空间
     //   //这样的目的，是为了将做为引用类型的string实现为通常语义下的字符串。

     //   int myInt = 1;
     //   int myInt2 = myInt;
     //   myInt = 100;
     //   print(myInt2);//myInt2 is still 1;

        print("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        RefData r1 = new RefData(); //在堆上分配
        ValData v1 = new ValData(); //在栈上分配
        r1.a = 1; //在托管堆上修改
        v1.a = 100; //在栈上修改
      
        RefData r2 = r1; //只复制引用（指针）
        ValData v2 = v1; //在栈上分配并复制成员

        r1.a = 2; //r1.a和r2.a都会更改
        v1.a = 200; //v1.a会更改，但v2.a不变


      


    }
}
