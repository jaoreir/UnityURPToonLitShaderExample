using UnityEngine;

public class MoveLight : MonoBehaviour
{
    public float radius = 2f;
    public float freq = 0.3f;
    Vector3 _initPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            _initPos
            + new Vector3(
                Mathf.Cos(Time.time * freq * 2 * Mathf.PI) * radius,
                0,
                Mathf.Sin(Time.time * freq * 2 * Mathf.PI) * radius
            );
    }
}
