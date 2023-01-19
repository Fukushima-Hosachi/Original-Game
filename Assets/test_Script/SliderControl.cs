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

    //�X���C�_�[�̒l���u�擾����v���߂̃p�u���b�N�ϐ����`����֐�
    //�擾�����l��Cube�̉�]�ւ̔��f�������ōs���܂��B
    public void SliderDemo_CubeRot(float newValue)
    {
        // �L���[�u����]�����邽�߂̕ϐ���錾
        // Vector3�ϐ���3�̒l���i�[�ł���^
        // ���̕ϐ��Ɍ��݂̃I�C���[�pxyz����
        // this�͂��̃X�N���v�g���A�^�b�`����GameObject��\��
        Vector3 rot = this.transform.localEulerAngles;

        // �c����y��������
        rot.x = newValue;

        // �V�������l���L���[�u�̊p�x�ɑ��
        this.transform.localEulerAngles = rot;
    }




 



    // Start is called before the first frame update
    void Start()
    {

        R_slider = GameObject.Find("Slide_R").GetComponent<Slider>();
        G_slider = GameObject.Find("Slide_G").GetComponent<Slider>();
        B_slider = GameObject.Find("Slide_B").GetComponent<Slider>();
        float R, G, B = 0;
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        
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
        }

    }


    public void SliderDemo_ColorChangeR(float newValue)
    {
        //�X���C�_�[�ŐF��ς�����
        //RGB

        //R,G,B�̊e�l��0�`255�ŃX���C�_�[�Œ���
        //�X���C�_�[�̒l��RGB�ɑ���
        Debug.Log("R=" + R);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }

    public void SliderDemo_ColorChangeG(float newValue)
    {
        //�X���C�_�[�ŐF��ς�����
        //RGB

        //R,G,B�̊e�l��0�`255�ŃX���C�_�[�Œ���
        //�X���C�_�[�̒l��RGB�ɑ���
        Debug.Log("G=" + G);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }

    public void SliderDemo_ColorChangeB(float newValue)
    {
        //�X���C�_�[�ŐF��ς�����
        //RGB

        //R,G,B�̊e�l��0�`255�ŃX���C�_�[�Œ���
        //�X���C�_�[�̒l��RGB�ɑ���
        Debug.Log("B=" + B);

        //gameObject.GetComponent<Renderer>().material.color = new Color(R , R, R);

    }


}
