using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private float _startXPosition = -3;
    [SerializeField] private float _finishXPosition = 3;
    
    private float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        var newPosition = new Vector3(Mathf.Lerp(_startXPosition, _finishXPosition, progress),transform.position.y,transform.position.y);
        transform.position = newPosition;
    }
}
