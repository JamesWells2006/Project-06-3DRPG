using UnityEngine;

public class Weapon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Example: destroy enemy
        }
    }
}


