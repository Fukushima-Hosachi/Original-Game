using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderControl : MonoBehaviour
{
    public Slider slider;
    public float RGB;

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

        slider = GameObject.Find("Slider").GetComponent<Slider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RGB = slider.value;
        Debug.Log(RGB);
        
    }


    public void SliderDemo_ClorChange(float newValue)
    {
        //�X���C�_�[�ŐF��ς�����
        //RGB

        //R,G,B�̊e�l��0�`255�ŃX���C�_�[�Œ���
        //�X���C�_�[�̒l��RGB�ɑ���
    }

}
