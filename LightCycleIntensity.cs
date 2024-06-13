using UnityEngine;

public class LightCycleIntensity : MonoBehaviour
{
    public Light light;
    public float intensity = 0.5f;
    public float amp = 0.5f;
    public float freq = 1.0f;
    public float phase = 0f;

    // Update is called once per frame
    void Update()
    {
        light.intensity = intensity + amp * Mathf.Sin(Time.time * freq * 2.0f * Mathf.PI + phase);
    }
}
