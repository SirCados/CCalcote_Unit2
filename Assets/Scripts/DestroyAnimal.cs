using UnityEngine;

public class DestroyAnimal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
