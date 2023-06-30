using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCount1 : MonoBehaviour
{
    /// <summary>
    /// sampleScene移動した際に最初にでてくる、テキストの文字を3、2、1、START変える処理をこのスクリプトで書いている
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
    public void CountEnd() //テキストを非アクティブ状態にする
    {
        text.enabled = false;
    }
}
