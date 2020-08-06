using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaivior : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject centerObject;
    Vector3 currentPosition = new Vector3(), angle, currentSpeed = new Vector3();
    float currentDistance, scalarAccelaration = 3f, shootingTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = currentSpeed * (Time.time-shootingTime) / currentDistance;

        currentPosition.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPosition.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        gameObject.transform.position = currentPosition;

        currentSpeed.x += scalarAccelaration * Time.deltaTime;
        currentSpeed.y += scalarAccelaration * Time.deltaTime;

    }

    public void Shoot(GameObject center, float distance)
    {
        centerObject = center;
        currentDistance = distance;
        shootingTime = Time.time;
    }
}
