using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] GameObject textBox; //��蕶��J�E���g�_�E���̕b���A�{�^���Ȃǂ̃A�N�e�B�u��Ԃ�؂�ւ��Ă���
    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
    }

    // Update is called once per frame
    public void textSwich() //SetActive��true�ɂ���
    {
        textBox.SetActive(true);
    }

    public void textSwich2() //SetActive��false�ɂ���
    {
        textBox.SetActive(false);
    }
}
