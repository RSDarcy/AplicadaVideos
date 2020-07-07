using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoAxisTouch : MonoBehaviour
{
   
    
    const float MIN_LIM_Y = -4.29f, MAX_LIM_Y = 4.29f, MIN_LIM_X = -1.8f, MAX_LIM_X =1.9f;
   
    public FloatingJoystick Joystick;
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(10,10);

    void Update()
    {
        _deltaPos.x = Joystick.Horizontal * _movementSpeed.x;
        _deltaPos.y = Joystick.Vertical * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
           Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
           gameObject.transform.position.z);

    }
}
