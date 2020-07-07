using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    float _Startingforce = 500f;
    bool _hasStarted = false;
    Rigidbody _rbody;
    Vector3 _startingForceVector = new Vector3(1,1);
    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_hasStarted && Input.GetButtonDown("Fire1"))
        {
            _hasStarted = true;
            _startingForceVector *= _Startingforce;
            _rbody.AddForce(_startingForceVector);
        }
    }
}
