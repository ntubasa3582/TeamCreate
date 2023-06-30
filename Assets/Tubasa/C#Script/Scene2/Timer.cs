using UnityEngine;
using UnityEngine.UI;   // Text ���g������
using UnityEngine.SceneManagement;

/// <summary>
/// �u�^�C�}�[�v���g���ăX�g�b�v�E�H�b�`�𐧌䂷��R���|�[�l���g
/// </summary>
public class Timer : MonoBehaviour
{
    /// <summary>���Ԃ�\������ Text �R���|�[�l���g</summary>
    [SerializeField] Text _stopWatch = default;
    /// <summary>�^�C�}�[</summary>
    public float _timer = 7;
    /// <summary>�X�g�b�v�E�H�b�`���v�������ǂ�����\���t���O�Btrue �̎��͌v�����Ƃ���B</summary>
    bool _isWorking = false;

    bool _swich = false;

    void Update()
    {
        if (_swich == true)
        {
            _isWorking = true;
        }
        if (_isWorking)    // �v����
        {
            // Time.deltaTime �́u�O��� Update ���������Ă���o�߂����b���v���擾�ł���BTime �N���X�́u���ԁv�Ɋ֌W�����@�\�����N���X�ł���B
            _timer -= Time.deltaTime;
            _stopWatch.text = _timer.ToString("F2");
            // ��ToString() �̈��� F2 �� �u'F'loat �̏����_�ȉ� '2' ���v�ɏ����w�肵�Ă���i�Q��: https://dobon.net/vb/dotnet/string/inttostring.html�j�B
            // ���̂悤�ɏ����w������Ȃ��ꍇ�A���Ɍ��Â炭�Ȃ�B
            // _stopWatch.text = m_timer.ToString();
            if (_timer <= 0)
            {
                Debug.Log("�Q�[���I�[�o�[");
                _isWorking = false;
                _swich = false;
                TextChange textChange = GetComponent<TextChange>();
                textChange.textSwich2();
                SceneManager.LoadScene("GameOver");
            }
        }

    }

    /// <summary>
    /// �X�g�b�v�E�H�b�`����~���Ă�����v�����J�n���A�v�����Ȃ�Όv�����~����
    /// </summary>
    public void StartPause()
    {
        if (_isWorking)
        {
            // TODO: �v�����Ȃ�΃X�g�b�v�E�H�b�`���~�߂�
            _isWorking = false;
        }
        else
        {
            // �v�����ł͂Ȃ��ꍇ�́A�v�����t���O�𗧂Ă�
            _isWorking = true;
        }
    }

    /// <summary>
    /// �X�g�b�v�E�H�b�`���~�߂āA�^�C�}�[�� 0 �ɂ���
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