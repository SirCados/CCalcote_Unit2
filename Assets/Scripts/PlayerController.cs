using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float Speed = 20.0f;
    public float HorizontalRange = 15.0f;
    public GameObject FoodProjectile;

    // Update is called once per frame
    void Update()
    {
        Move();
        ShootFood();
    }

    void Move()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -HorizontalRange)
        {
            transform.position = new Vector3(-HorizontalRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > HorizontalRange)
        {
            transform.position = new Vector3(HorizontalRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * Speed);       
    }

    void ShootFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(FoodProjectile, transform.position, FoodProjectile.transform.rotation);
        }
    }
}
