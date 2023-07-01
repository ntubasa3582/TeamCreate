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

    [SerializeField] Button buttonL; //ボタンを取ってくる
    [SerializeField] Button buttonR; //ボタンを取ってくる
    [SerializeField] Button buttonC; //ボタンを取ってくる
    /// <summary>
    /// 問題数
    /// </summary>
    public int _count1;
    bool _button1;
    bool _button2;
    bool _button3;
    /// <summary>
    /// 問題に正解するたびに増えるカウントこの変数の数字が上がるごとに問題の文字や色が変わる
    /// </summary>
    int _mondaicount;
    int _levelcount;
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

        if (_mondaicount >= 3) //8問目の時に_levelcountが1上がる
        {
            _levelcount = 1;
            buttonC. GetComponent<Renderer>().material.color = new Color32(0,255,0,0);
            buttonL.image.color = Color.white;
            buttonR.image.color = Color.white;
        }
    }
    public void Count1() //正解のボタンが押されたら_count1の変数に１足される
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

        if (_ran == 1) //10問目と9問目の1が出た場合の処理
        {
            int _Ran = Random.Range(1, 3);
            while (_Ran == _num)
            {
                _Ran = Random.Range(1, 3);
            }

            if (_Ran == 1) //ランダムの中で更にランダムを行う
            {
                text1.text = "黄色はどれですか？";
            }
            if (_Ran == 2)
            {
                text1.text = "赤い文字はどれですか？";
            }

            _button1 = true;
            Debug.Log("1");
        }
        if (_ran == 2) //10問目と9問目の2が出た場合の処理
        {
            int _Ran1 = Random.Range(1, 3);
            while (_Ran1 == _num)
            {
                _Ran1 = Random.Range(1, 3);
            }
            if (_Ran1 == 1)
            {
                text1.text = "赤色はどれですか？";
            }
            if (_Ran1 == 2)
            {
                text1.text = "黄色の文字はどれですか？";
            }

            _button2 = true;
            Debug.Log("2");
        }
        if (_ran == 3) //10問目と9問目の3が出た場合の処理
        {
            int _Ran2 = Random.Range(1, 3);
            while (_Ran2 == _num)
            {
                _Ran2 = Random.Range(1, 3);
            }
            if (_Ran2 == 1)
            {
                text1.text = "オレンジはどれですか？";
            }
            if (_Ran2 == 2)
            {
                text1.text = "青い文字はどれですか？";
            }

            _button3 = true;
            Debug.Log("3");
        }

        if (_ran ==1 && _levelcount == 1) //8問目と7問目に1が出た場合の処理
        {

        }
        _num = _ran;
    }
}
