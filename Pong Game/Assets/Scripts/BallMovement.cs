using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float MoveSpeed;
    Vector3 BallDirection;
    // Start is called before the first frame update
    void Start()
    {
        BallDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        BallDirection = BallDirection.normalized;
    }

    void Update()
    {
        transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
        }
    }

}
