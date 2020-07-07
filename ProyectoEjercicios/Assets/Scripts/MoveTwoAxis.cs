using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class MoveTwoAxis : MonoBehaviour
{
    Vector3 _movementSpeed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();
    const float MIM_LIM_Y =-4.4f, MAX_LIM_Y =4.4f, MIM_LIM_X =-8.25f, MAX_LIM_X =8.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;
        
        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, MIM_LIM_X, MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y, MIM_LIM_Y, MAX_LIM_Y),gameObject.transform.position.z);

    }
}
