using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCount1 : MonoBehaviour
{
    /// <summary>
    /// sampleScene�ړ������ۂɍŏ��ɂłĂ���A�e�L�X�g�̕�����3�A2�A1�ASTART�ς��鏈�������̃X�N���v�g�ŏ����Ă���
    /// </summary>

    [SerializeField] Text text;

    public void Count3()
    {
        text.text = "3";
    }
    public void Count2()
    {
        text.text = "2";
    }
    public void Count1() 
    {
        text.text = "1";
    }
    public void CountStart()
    {
        text.text = "START";
    }
    public void CountEnd() //�e�L�X�g���A�N�e�B�u��Ԃɂ���
    {
        text.enabled = false;
    }
}
