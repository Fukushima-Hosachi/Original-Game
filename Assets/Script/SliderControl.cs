using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderControl : MonoBehaviour
{
    public Slider R_slider, G_slider, B_slider;
    //public float RGB;
    public float R;
    public float G;
    public float B;
    GameObject Square;
    public GameObject button;

    //スライダーの値を「取得する」ためのパブリック変数を定義する関数
    //取得した値のCubeの回転への反映もここで行います。


    // Start is called before the first frame update
    void Start()
    {

        R_slider = GameObject.Find("Slide_R").GetComponent<Slider>();
        G_slider = GameObject.Find("Slide_G").GetComponent<Slider>();
        B_slider = GameObject.Find("Slide_B").GetComponent<Slider>();
        float R, G, B = 0;
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);

        button = GameObject.Find("Start_Button").GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        R = R_slider.value;
        G = G_slider.value;
        B = B_slider.value;

        gameObject.GetComponent<Renderer>().material.color = new Color(R, G, B);

        if (R == 1 && G == 1 && B ==1)
        {
            Debug.Log("moon is too brignt");
            button.SetActive(true);

        }

    }


    public void SliderDemo_ColorChangeR(float newValue)
    {
        //スライダーで色を変えたい
        //RGB

        //R,G,Bの各値を0～255でスライダーで調整
        //スライダーの値をRGBに送る
        Debug.Log("R=" + R);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }

    public void SliderDemo_ColorChangeG(float newValue)
    {
        //スライダーで色を変えたい
        //RGB

        //R,G,Bの各値を0～255でスライダーで調整
        //スライダーの値をRGBに送る
        Debug.Log("G=" + G);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }

    public void SliderDemo_ColorChangeB(float newValue)
    {
        //スライダーで色を変えたい
        //RGB

        //R,G,Bの各値を0～255でスライダーで調整
        //スライダーの値をRGBに送る
        Debug.Log("B=" + B);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }


}
