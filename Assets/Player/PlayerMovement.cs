using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float drag;
    [SerializeField] public Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        // body.velocity = (new Vector2(xInput, yInput).normalized) * speed;

        if (Mathf.Abs(xInput) > 0)
        {
            body.velocity = new Vector2(xInput * speed, body.velocity.y);
        }
        if (Mathf.Abs(yInput) > 0)
        {
            body.velocity = new Vector2(body.velocity.x, yInput * speed);
        }
    }

    void FixedUpdate()
    {
        body.velocity *= drag;
    }
}
