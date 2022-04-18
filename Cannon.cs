using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private ConnonballGenerator _cannonballGenerator;
    private Vector2 _direction;
    private Cannonball _cannonball;
    private int _angleLimit = 9;

    private void Start()
    {
        _direction = new Vector2(1, 1);
    }

    private void OnMouseDown()
    {
        _cannonball = _cannonballGenerator.SpawnCannonball();
        _cannonball.Push(_direction);
    }

    public void AddYForce()
    {
        if (transform.rotation.z < _angleLimit)
        {
            _direction.y += 0.3f;
            transform.Rotate(new Vector3(0, 0, 3));
        }
    }

    public void TakeYForce()
    {
        if (transform.rotation.z > -_angleLimit)
        {
            _direction.y -= 0.3f;
            transform.Rotate(new Vector3(0, 0, -3));
        }
    }
}