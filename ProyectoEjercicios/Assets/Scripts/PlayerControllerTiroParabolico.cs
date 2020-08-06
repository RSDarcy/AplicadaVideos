using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTiroParabolico : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Munition;
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();
   

    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ?
            (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY = userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;
        currentAngle = Mathf.Atan(deltaY / deltaX);

        Debug.Log(currentAngle * Mathf.Rad2Deg); //convertir a grados como unity manda en radianes

        //Trigger;
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Munition, gameObject.transform.position, Quaternion.identity).GetComponent<MunitionBehaivior>().Shoot(startingSpeed, currentAngle);
        }


    }
}
