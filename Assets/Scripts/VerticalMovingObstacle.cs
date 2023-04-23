using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _startYPosition = -2;
    [SerializeField] private float _finishYPosition = 2;
    
    private float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        var newPosition= new Vector3(transform.position.x,Mathf.Lerp(_startYPosition, _finishYPosition, progress),transform.position.y);
        transform.position = newPosition;
    }
}
