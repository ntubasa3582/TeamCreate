using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MondaiController : MonoBehaviour
{
    /// <summary>
    /// 問題文の入っている変数
    /// </summary>
    [SerializeField] Text _text;
    [SerializeField, Header("ボタンLeft")] Button _buttonL;
    /// <summary>
    /// ボタンLに付いているテキスト
    /// </summary>
    [SerializeField] Text _buttonLText; 
    [SerializeField, Header("ボタンCenter")] Button _buttonC;
    /// <summary>
    /// ボタンCに付いているテキスト
    /// </summary>
    [SerializeField] Text _buttonCText;
    [SerializeField, Header("ボタンRight")] Button _buttonR;
    /// <summary>
    /// ボタンRに付いているテキスト
    /// </summary>
    [SerializeField] Text _buttonRText;
    bool _butoonLS; //ボタンLが正解ならTrue
    bool _butoonCS; //ボタンCが正解ならTrue
    bool _butoonRS; //ボタンRが正解ならTrue

    /// <summary>
    /// ランダムの値
    /// </summary>
    int _rnd;
    // Start is called before the first frame update
    void Start()
    {
        _rnd = Random.Range(1, 3);
        Mondai1(); //問題1
    }

    // Update is called once per frame
    void Mondai1() //問題1の条件文
    {
    }

    public void Seikai()
    {
        //正解の音が鳴る

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
        //不正解の音が鳴る
        SceneManager.LoadScene("Stage1B");
    }

    public void Huseikai2()
    {
        //不正解の音が鳴る
        SceneManager.LoadScene("Stage1B");
    }
}
