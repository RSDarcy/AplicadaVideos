﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CubeInstanciator : MonoBehaviour
{
    public GameObject RedCube, YellowCube, BlueCube, GreenCube;
    Vector3 _startingPosition = new Vector3(0, 7.7f);
    float _nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_X=-11.35f, MAX_X=11.35f;
    void Start()
    {
        _nextTime = GetNextTime();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > _nextTime)
        {
            _startingPosition.x = Random.Range(MIN_X,MAX_X);
            Instantiate(NextCube(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();
        }
        
    }

    float GetNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject NextCube()
    {
        switch(Random.Range(0,4))
        {
            case 0:
                return RedCube;
            case 1:
                return BlueCube;
            case 2:
                return YellowCube;
            default:
                return GreenCube;
        }
    }
  }
