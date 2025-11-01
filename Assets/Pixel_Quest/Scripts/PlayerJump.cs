using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float jumpForce = 8;
    public float fallForce = 1.5f;
    private Vector2 _gravityVector;
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    public Transform feetCollider;
    public LayerMask groundmask;
    private bool _groundCheck;
    private bool _waterCheck;
    private string _waterTag = "Water";
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _gravityVector = new Vector2(0, Physics2D.gravity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(_waterTag))
        {
            _waterCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag))
        {
            _waterCheck = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundmask);

        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || _waterCheck))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }

        if (_rigidbody2D.velocity.y < 0 && !_waterCheck)
        {
            _rigidbody2D.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
    }
}
