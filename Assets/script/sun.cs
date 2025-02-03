using UnityEngine;

public class SunRotation : MonoBehaviour
{
    public float rotationSpeed = 5f; // Vitesse de rotation du Soleil

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
