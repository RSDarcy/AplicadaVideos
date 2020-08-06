using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMovUniforVariado : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Shield;
    const float shieldDistance = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Instantiate(Shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldBehaivior>().Shoot(gameObject, shieldDistance);
        }

    }
}
