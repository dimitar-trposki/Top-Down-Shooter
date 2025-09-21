using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody body;

    public float speed;

    public Camera cam;

    private Health _health;

    void Start()
    {
        body = GetComponent<Rigidbody>();

        _health = FindObjectOfType<Health>();
    }

    void Update()
    {
        Move();

        Rotate();
    }

    void Move()
    {
        Vector3 ourVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            ourVelocity += transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            ourVelocity += transform.forward * -speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            ourVelocity += transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            ourVelocity += transform.right * -speed;
        }

        body.linearVelocity = ourVelocity;
    }

    void Rotate()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.point.y <= transform.position.y)
            {
                Vector3 hitPoint = hit.point;

                hitPoint.y = transform.position.y;

                transform.LookAt(hitPoint);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("EnemyGreen"))
        {
            _health.ChangeHealth(10);
        }

        if (collision.gameObject.name.Contains("EnemyRed"))
        {
            _health.ChangeHealth(20);
        }
    }
}