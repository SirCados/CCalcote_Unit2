using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        MoveObjectForward();
    }

    void MoveObjectForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
