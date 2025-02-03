using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform earth; // Référence à la Terre
    public float orbitSpeed = 15f; // Vitesse de révolution autour de la Terre
    public float orbitRadius = 2f; // Distance Terre-Lune

    private float angle; // Angle pour la position orbitale

    void Update()
    {
        // Mouvement de la Lune autour de la Terre
        angle += orbitSpeed * Time.deltaTime;
        float x = Mathf.Cos(angle) * orbitRadius;
        float z = Mathf.Sin(angle) * orbitRadius;
        transform.position = new Vector3(earth.position.x + x, transform.position.y, earth.position.z + z);
    }
}
