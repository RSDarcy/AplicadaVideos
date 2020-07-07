using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    Vector3 CurrentPosition = new Vector3();
    const float MAX_Y = 8f, _speedY= 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentPosition.y = -4 + Mathf.PingPong(Time.time * _speedY, MAX_Y);
        gameObject.transform.position = CurrentPosition;
    }
}
