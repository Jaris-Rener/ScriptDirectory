using UnityEngine;

public class Rotator
    : MonoBehaviour
{
    public Vector3 Rotation;

    private void Update()
    {
        transform.Rotate(Rotation);
    }
}