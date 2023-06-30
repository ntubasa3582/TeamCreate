using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] GameObject textBox; //問題文やカウントダウンの秒数、ボタンなどのアクティブ状態を切り替えている
    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
    }

    // Update is called once per frame
    public void textSwich() //SetActiveをtrueにする
    {
        textBox.SetActive(true);
    }

    public void textSwich2() //SetActiveをfalseにする
    {
        textBox.SetActive(false);
    }
}
