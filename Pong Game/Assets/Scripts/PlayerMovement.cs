using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    public int playerSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * Time.deltaTime * playerSpeed, 0));
        }

        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * Time.deltaTime * playerSpeed, 0));
        }
    }
}
