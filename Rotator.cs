using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotation;

    private void Update()
    {
        transform.Rotate(rotation);
    }
}