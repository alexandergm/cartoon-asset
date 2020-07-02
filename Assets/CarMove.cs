using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    [SerializeField] private CinematicController _cinematicController;
    private Vector3 _movingVector;
    private bool _isCarStopped = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_isCarStopped) return;
        //Debug.Log(transform.position.z);
        if (transform.position.z < 37.68f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime*_speed);
            return;
        }

        if (!_isCarStopped)
        {
            _cinematicController.StartLevel();
            _isCarStopped = true;
        }
        
    }
}
