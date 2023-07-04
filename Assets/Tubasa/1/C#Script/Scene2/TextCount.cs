using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextCount : MonoBehaviour
{
    [SerializeField] Text text; //��萔��\������Text������Ă���
    /// <summary>
    /// ��蕶��\������e�L�X�g�G
    /// </summary>
    [SerializeField] Text text1;

    [SerializeField] Button buttonL; //�{�^��������Ă���
    [SerializeField] Button buttonR; //�{�^��������Ă���
    [SerializeField] Button buttonC; //�{�^��������Ă���
    /// <summary>
    /// ��萔
    /// </summary>
    public int _count1;
    bool _button1;
    bool _button2;
    bool _button3;
    /// <summary>
    /// ���ɐ������邽�тɑ�����J�E���g���̕ϐ��̐������オ�邲�Ƃɖ��̕�����F���ς��
    /// </summary>
    int _mondaicount;
    int _levelcount;
    //bool _randomSwich = true;
    // Start is called before the first frame update
    void Start()
    {
        text.text = _count1.ToString(); //_count1�̕ϐ�������Ă���Text�ŕ\������
        Rnd();
        
    }

    // Update is called once per frame
    void Update() //_count�̕ϐ��̒l��0�����������Ȃ������ʂɕ\������Ă���{�^����e�L�X�g��\�������Ȃ�����
    {
        if (_count1 <= 0)
        {
            TextChange textChange = GetComponent<TextChange>();
            textChange.textSwich2();
            SceneManager.LoadScene("GameClear");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Count1();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Count2();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Count3();
        }

        if (_mondaicount >= 3) //8��ڂ̎���_levelcount��1�オ��
        {
            _levelcount = 1;
            buttonC. GetComponent<Renderer>().material.color = new Color32(0,255,0,0);
            buttonL.image.color = Color.white;
            buttonR.image.color = Color.white;
        }
    }
    public void Count1() //�����̃{�^���������ꂽ��_count1�̕ϐ��ɂP�������
    {
        if (_button1 == true)
        {
            _mondaicount++;
            _count1--;
            text.text = _count1.ToString("");
            _button1 = false;
            Rnd();
        }
    }
    public void Count2()
    {
        if (_button2 == true)
        {
            _mondaicount++;
            _count1--;
            text.text = _count1.ToString("");
            _button2 = false;
            Rnd();
        }

    }
    public void Count3()
    {
        if (_button3 == true)
        {
            _mondaicount++;
            _count1--;
            text.text = _count1.ToString("");
            _button3 = false;
            Rnd();
        }
    }
    int _num = 0;
    public void Rnd()
    {
        int _ran = Random.Range(1, 4);

        while (_ran == _num)
        {
            _ran = Random.Range(1, 4);
        }

        //text1.text = _ran.ToString("");

        if (_ran == 1) //10��ڂ�9��ڂ�1���o���ꍇ�̏���
        {
            int _Ran = Random.Range(1, 3);
            while (_Ran == _num)
            {
                _Ran = Random.Range(1, 3);
            }

            if (_Ran == 1) //�����_���̒��ōX�Ƀ����_�����s��
            {
                text1.text = "���F�͂ǂ�ł����H";
            }
            if (_Ran == 2)
            {
                text1.text = "�Ԃ������͂ǂ�ł����H";
            }

            _button1 = true;
            Debug.Log("1");
        }
        if (_ran == 2) //10��ڂ�9��ڂ�2���o���ꍇ�̏���
        {
            int _Ran1 = Random.Range(1, 3);
            while (_Ran1 == _num)
            {
                _Ran1 = Random.Range(1, 3);
            }
            if (_Ran1 == 1)
            {
                text1.text = "�ԐF�͂ǂ�ł����H";
            }
            if (_Ran1 == 2)
            {
                text1.text = "���F�̕����͂ǂ�ł����H";
            }

            _button2 = true;
            Debug.Log("2");
        }
        if (_ran == 3) //10��ڂ�9��ڂ�3���o���ꍇ�̏���
        {
            int _Ran2 = Random.Range(1, 3);
            while (_Ran2 == _num)
            {
                _Ran2 = Random.Range(1, 3);
            }
            if (_Ran2 == 1)
            {
                text1.text = "�I�����W�͂ǂ�ł����H";
            }
            if (_Ran2 == 2)
            {
                text1.text = "�������͂ǂ�ł����H";
            }

            _button3 = true;
            Debug.Log("3");
        }

        if (_ran ==1 && _levelcount == 1) //8��ڂ�7��ڂ�1���o���ꍇ�̏���
        {

        }
        _num = _ran;
    }
}
