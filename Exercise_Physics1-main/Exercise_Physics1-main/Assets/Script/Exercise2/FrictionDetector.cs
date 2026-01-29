using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FrictionColorChanger : MonoBehaviour
{
    public Gradient colorGradient; // Set colors in Inspector
    public float maxFriction = 10f; // Adjust for sensitivity

    private Rigidbody rb;
    private Renderer rend;
    private Vector3 lastVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        // Default gradient if none assigned
        if (colorGradient == null)
        {
            colorGradient = new Gradient();
            colorGradient.SetKeys(
                new GradientColorKey[] {
                    new GradientColorKey(Color.blue, 0f),
                    new GradientColorKey(Color.green, 0.5f),
                    new GradientColorKey(Color.red, 1f)
                },
                new GradientAlphaKey[] {
                    new GradientAlphaKey(1f, 0f),
                    new GradientAlphaKey(1f, 1f)
                }
            );
        }
    }

    void FixedUpdate()
    {
        // Estimate friction using velocity change
        Vector3 velocityChange = (rb.velocity - lastVelocity) / Time.fixedDeltaTime;
        float frictionAmount = velocityChange.magnitude;

        lastVelocity = rb.velocity;

        // Normalize friction value
        float t = Mathf.Clamp01(frictionAmount / maxFriction);

        // Change color based on friction
        rend.material.color = colorGradient.Evaluate(t);
    }
}