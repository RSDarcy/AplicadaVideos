using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScriptsScore : MonoBehaviour
{
    ScoreManager _scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = GameObject.Find("ScoreManagerText").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            _scoreManager.IncrementScore();
        }
    }
}
