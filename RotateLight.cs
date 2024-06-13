using UnityEngine;

public class RotateLight : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        var angles = transform.rotation.eulerAngles;
        angles.y += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(angles);
    }
}
