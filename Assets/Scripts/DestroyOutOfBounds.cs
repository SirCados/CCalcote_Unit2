using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopBoundary = 30.0f;
    private float BottomBoundary = -10.0f;

    // Update is called once per frame
    void Update()
    {
        DestroyIfOutOfBounds();
    }

    void DestroyIfOutOfBounds()
    {        
        if (transform.position.z > TopBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < BottomBoundary)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
