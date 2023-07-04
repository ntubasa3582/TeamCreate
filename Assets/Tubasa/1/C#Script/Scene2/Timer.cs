using UnityEngine;
using UnityEngine.UI;   // Text を使うため
using UnityEngine.SceneManagement;

/// <summary>
/// 「タイマー」を使ってストップウォッチを制御するコンポーネント
/// </summary>
public class Timer : MonoBehaviour
{
    /// <summary>時間を表示する Text コンポーネント</summary>
    [SerializeField] Text _stopWatch = default;
    /// <summary>タイマー</summary>
    public float _timer = 7;
    /// <summary>ストップウォッチが計測中かどうかを表すフラグ。true の時は計測中とする。</summary>
    bool _isWorking = false;

    bool _swich = false;

    void Update()
    {
        if (_swich == true)
        {
            _isWorking = true;
        }
        if (_isWorking)    // 計測中
        {
            // Time.deltaTime は「前回の Update が完了してから経過した秒数」を取得できる。Time クラスは「時間」に関係した機能を持つクラスである。
            _timer -= Time.deltaTime;
            _stopWatch.text = _timer.ToString("F2");
            // ↑ToString() の引数 F2 は 「'F'loat の小数点以下 '2' 桁」に書式指定している（参照: https://dobon.net/vb/dotnet/string/inttostring.html）。
            // ↓のように書式指定をしない場合、非常に見づらくなる。
            // _stopWatch.text = m_timer.ToString();
            if (_timer <= 0)
            {
                Debug.Log("ゲームオーバー");
                _isWorking = false;
                _swich = false;
                TextChange textChange = GetComponent<TextChange>();
                textChange.textSwich2();
                SceneManager.LoadScene("GameOver");
            }
        }

    }

    /// <summary>
    /// ストップウォッチが停止していたら計測を開始し、計測中ならば計測を停止する
    /// </summary>
    public void StartPause()
    {
        if (_isWorking)
        {
            // TODO: 計測中ならばストップウォッチを止める
            _isWorking = false;
        }
        else
        {
            // 計測中ではない場合は、計測中フラグを立てる
            _isWorking = true;
        }
    }

    /// <summary>
    /// ストップウォッチを止めて、タイマーを 0 にする
    /// </summary>
    public void Reset()
    {
        //if (_isWorking)
        //{
        //    _isWorking = false;
        //}

        //_timer = 0;
        //_stopWatch.text = _timer.ToString("F2");
    }

    public void TimerStart()
    {
        _swich = true;
    }
}