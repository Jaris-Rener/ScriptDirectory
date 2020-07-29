using System;
using UnityEngine;

public class Billboard
    : MonoBehaviour
{
    private Transform _camera;

    void Update ()
    {
        if(_camera == null)
        {
            if(Camera.main == null)
                return;

            _camera = Camera.main.transform;
        }

        transform.LookAt(_camera.position, Vector3.up);
        transform.Rotate(0, 180, 0);
    }
}
