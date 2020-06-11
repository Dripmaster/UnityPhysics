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

    void FixedUpdate()
    {
        _rigidbody.MovePosition((Vector2)transform.position + moveDir * Time.deltaTime);
    }
}
