using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderControl : MonoBehaviour
{
    public Slider slider;
    public float RGB;
    GameObject Square;

    //スライダーの値を「取得する」ためのパブリック変数を定義する関数
    //取得した値のCubeの回転への反映もここで行います。
    public void SliderDemo_CubeRot(float newValue)
    {
        // キューブを回転させるための変数を宣言
        // Vector3変数は3つの値を格納できる型
        // その変数に現在のオイラー角xyzを代入
        // thisはこのスクリプトをアタッチしたGameObjectを表す
        Vector3 rot = this.transform.localEulerAngles;

        // 縦軸のy成分を代入
        rot.x = newValue;

        // 新しい数値をキューブの角度に代入
        this.transform.localEulerAngles = rot;
    }




 



    // Start is called before the first frame update
    void Start()
    {

        slider = GameObject.Find("Slider").GetComponent<Slider>();
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        RGB = slider.value;
        Debug.Log(RGB);
        
    }


    public void SliderDemo_ClorChange(float newValue)
    {
        //スライダーで色を変えたい
        //RGB

        //R,G,Bの各値を0～255でスライダーで調整
        //スライダーの値をRGBに送る

        gameObject.GetComponent<Renderer>().material.color = new Color(RGB , RGB, RGB);

    }

}
