using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float BallForce = 500f;
    public float ConstantBallForce = 20f;
    Vector2 MyVelocity = new Vector2(1, 1);
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        rb.AddForce(MyVelocity * BallForce);
    }
}
