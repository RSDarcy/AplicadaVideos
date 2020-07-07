using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAxisTouchMovment : MonoBehaviour
{
    float _speedY = 2;
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIM_Y = -4.29f, MAX_LIM_Y = 4.29f;
    // Start is called before the first frame update

    void Update()
    {
        _deltaPos.y = Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position.y : 0;
        _deltaPos.y *= _speedY;
        _deltaPos *=Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x,
            Mathf.Clamp(gameObject.transform.position.y,MIN_LIM_Y,MAX_LIM_Y),
            gameObject.transform.position.z);

    }
}
