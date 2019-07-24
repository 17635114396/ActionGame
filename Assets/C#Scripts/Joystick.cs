using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
public class Joystick : MonoBehaviour
{
    private bool isPress=false;//是否按下，默认为否
    private Transform button;//按钮的位置
    public static float h=0f;
    public static float v=0f;
    // Start is called before the first frame update
    private void Awake()
    {
        button = transform.Find("Button");//初始化button位置
    }
    void Start()
    {
        
    }
    void OnPress(bool isPress)//是否按下传参进本对象。
    {
        this.isPress = isPress;//初始化按下
        if (isPress == false)
        {

            button.localPosition = Vector3.zero;//如果没按下，则还原按钮位置为局部坐标原点
            h = 0;v = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isPress)
        {
            Vector2 tochPos = UICamera.lastTouchPosition;//按下的位置
            tochPos -= new Vector2(91, 91);//用来自减，来达到获取子按钮位置的作用
            float distance = Vector2.Distance(Vector2.zero, tochPos);//获取局部中心到触摸点的距离
            if (distance > 73)//距离太长，超出圆圈时
            {
                tochPos = tochPos.normalized * 73;//单位化乘长度
                button.localPosition = tochPos;//赋值为touchpos
            }
            else//不超出时
            {
                button.localPosition = tochPos;//button的局部坐标赋值为touchPos
            }
            h = tochPos.x / 73;
            v = tochPos.y / 73;
        }
    }
   
}
*/