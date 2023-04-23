using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _scaleMultiplier = 2f;
    
    private float _currentTime;
    private Vector3 _startScale;
    private Vector3 _finalScale;

    private void Start()
    {
        _startScale = transform.localScale;
        _finalScale = transform.localScale * _scaleMultiplier;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        transform.localScale = Vector3.Lerp(_startScale,_finalScale,progress);
    }
}
