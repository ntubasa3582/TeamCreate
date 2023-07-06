using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleRandom : MonoBehaviour
{
    int _rnd;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Rnd()
    {
        _rnd = Random.Range(1, 3);
        if(_rnd ==1 )
        {
            SceneManager.LoadScene("Stage1A");
        }
        if(_rnd ==2 )
        {
            Debug.Log("Žc”O");
        }
    }

    void Stage1a()
    {
        
    }
}
