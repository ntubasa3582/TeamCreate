using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleController : MonoBehaviour
{
    [SerializeField] GameObject obj;
    public int _count;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage()
    {
        _count++;
        Debug.Log("ˆÚ“®");
        SceneManager.LoadScene("sample");
    }
}
