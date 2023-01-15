using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text textlabel;
    public string charaname;
    public string [] word;
    //public AudioClip sound;

    private int num = 0;
    

    // Start is called before the first frame update
    void Start()
    {
     
        //\nで改行
        textlabel.text = charaname + "\n" + word[ num ] ;
        

        Debug.Log("first");
    }

    // Update is called once per frame
    void Update()
    {

        if ( Input.GetKeyDown ( KeyCode.Space ) )
        {
            if  (num == word.Length - 1 )
            {
                return;
            }

            num += 1;

            textlabel.text = charaname + "\n" + word[num];

            Debug.Log("ボタンを押し、進みます");
        }

        //AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

        
            
        
    }
}
