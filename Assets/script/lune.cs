using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    public Transform sun; // Référence au Soleil
    public float rotationSpeed = 10f; // Rotation sur elle-même
    public float orbitSpeed = 5f; // Vitesse de révolution autour du Soleil
    public float orbitRadius = 10f; // Distance Terre-Soleil

    private float angle; // Angle pour calculer la position orbitale

    void Update()
    {
        // 1. Rotation sur elle-même
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // 2. Révolution autour du Soleil
        angle += orbitSpeed * Time.deltaTime;
        float x = Mathf.Cos(angle) * orbitRadius;
        float z = Mathf.Sin(angle) * orbitRadius;
        transform.position = new Vector3(sun.position.x + x, transform.position.y, sun.position.z + z);
    }
}
