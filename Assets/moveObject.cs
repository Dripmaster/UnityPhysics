using UnityEngine;

public class moveObject : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    public Vector2 moveDir;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(), GetComponentsInChildren<BoxCollider2D>()[1]);
    }
    public bool isPlayer;

    void FixedUpdate()
    {
        if (isPlayer)
        {
            Vector2 vel = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
            {
                vel.y += 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                vel.y -= 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                vel.x -= 1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                vel.x += 1;
            }

            if (vel != Vector2.zero)
            {
                _rigidbody.MovePosition((Vector2)transform.position + vel * Time.deltaTime);
            }
        }
        else
            _rigidbody.MovePosition((Vector2)transform.position + moveDir * Time.deltaTime);
    }
    /*
     * void FixedUpdate()
    {
        _rigidbody.MovePosition((Vector2)transform.position + moveDir * Time.deltaTime);
    }
    */
}
