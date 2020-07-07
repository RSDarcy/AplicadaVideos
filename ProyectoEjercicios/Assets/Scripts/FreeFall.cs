using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    Vector3 deltaPos = new Vector3();
    Vector3 currentSpeeed = new Vector3();
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {   //Yf = Y0+ Voy * T +(aT al cuadrado)/2;
        deltaPos.y = currentSpeeed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime,2)/2;
        gameObject.transform.Translate(deltaPos);
        currentSpeeed += Physics.gravity * Time.deltaTime;
    }
}
