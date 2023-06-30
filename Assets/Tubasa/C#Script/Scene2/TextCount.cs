using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextCount : MonoBehaviour
{
    [SerializeField] Text text; //問題数を表示するTextを取ってくる
    /// <summary>
    /// 問題文を表示するテキスト；
    /// </summary>
    [SerializeField] Text text1;
    /// <summary>
    /// 問題数
    /// </summary>
    public int _count1;
    bool _button1;
    bool _button2;
    bool _button3;
    //bool _randomSwich = true;
    // Start is called before the first frame update
    void Start()
    {
        text.text = _count1.ToString(); //_count1の変数を取ってきたTextで表示する
        Rnd();
    }

    // Update is called once per frame
    void Update() //_countの変数の値が0よりも小さくなったら画面に表示されているボタンやテキストを表示させなくする
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
    }
    public void Count1() //正解のボタンが押されたら_count1の変数に１足される
    {
        if (_button1 == true)
        {
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

        text1.text = _ran.ToString("");

        if (_ran == 1)
        {
            _button1 = true;
            Debug.Log("1");
        }
        if (_ran == 2)
        {
            _button2 = true;
            Debug.Log("2");
        }
        if (_ran == 3)
        {
            _button3 = true;
            Debug.Log("3");
        }
        _num = _ran;
    }
}
