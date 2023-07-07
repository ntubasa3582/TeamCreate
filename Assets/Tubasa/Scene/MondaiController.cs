using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MondaiController : MonoBehaviour
{
    /// <summary>
    /// ��蕶�̓����Ă���ϐ�
    /// </summary>
    [SerializeField] Text _text;
    [SerializeField, Header("�{�^��Left")] Button _buttonL;
    /// <summary>
    /// �{�^��L�ɕt���Ă���e�L�X�g
    /// </summary>
    [SerializeField] Text _buttonLText; 
    [SerializeField, Header("�{�^��Center")] Button _buttonC;
    /// <summary>
    /// �{�^��C�ɕt���Ă���e�L�X�g
    /// </summary>
    [SerializeField] Text _buttonCText;
    [SerializeField, Header("�{�^��Right")] Button _buttonR;
    /// <summary>
    /// �{�^��R�ɕt���Ă���e�L�X�g
    /// </summary>
    [SerializeField] Text _buttonRText;
    bool _butoonLS; //�{�^��L�������Ȃ�True
    bool _butoonCS; //�{�^��C�������Ȃ�True
    bool _butoonRS; //�{�^��R�������Ȃ�True

    /// <summary>
    /// �����_���̒l
    /// </summary>
    int _rnd;
    // Start is called before the first frame update
    void Start()
    {
        _rnd = Random.Range(1, 3);
        Mondai1(); //���1
    }

    // Update is called once per frame
    void Mondai1() //���1�̏�����
    {
    }

    public void Seikai()
    {
        //�����̉�����

        Debug.Log(_rnd);
        if (_rnd == 1)
        {
            SceneManager.LoadScene("Stage2A");
        }
        if(_rnd == 2)
        {
            SceneManager.LoadScene("Stage2B");
        }
    }

    public void Huseikai1()
    {
        //�s�����̉�����
        SceneManager.LoadScene("Stage1B");
    }

    public void Huseikai2()
    {
        //�s�����̉�����
        SceneManager.LoadScene("Stage1B");
    }
}
