using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    float _scrollingSpeed = 0.2f, _currentTempSpeed;
    Vector2 _currentPosition = new Vector2();

    MeshRenderer _renderer;

    // Start is called before the first frame update
    void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTempSpeed = _scrollingSpeed * (20/ gameObject.transform.position.z);
        _currentPosition.x = _currentPosition.x + _currentTempSpeed * Time.deltaTime;
        //_currentPosition.y = _currentPosition.y + _scrollingSpeed * Time.deltaTime;

        _renderer.material.mainTextureOffset = _currentPosition;
    }
}
