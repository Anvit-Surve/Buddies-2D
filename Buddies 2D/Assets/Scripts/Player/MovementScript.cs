using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb2d;
    public float movementSpeed;
    public float jump;
    private int extraJumps;
    public int extraJumpValue;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        extraJumps = extraJumpValue;
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        float horizontal = Input.GetAxisRaw("Horizontal");
        MoveCharacter(horizontal);

    }
    private void Update()
    {
        bool vertical = Input.GetKeyDown(KeyCode.Space);
        if (vertical)
        {
            PlayerJump();
        }
    }
    private void PlayerJump()
    {
        if (isGrounded)
        {
            extraJumps = 2;
        }
        if (extraJumps > 0)
        {
            rb2d.velocity = Vector2.up * jump;
            extraJumps--;
        }
        else if (extraJumps == 0 && isGrounded)
        {
            rb2d.velocity = Vector2.up * jump;
        }
    }
    private void MoveCharacter(float horizontal)
    {
        Vector2 position = transform.position;
        position.x += horizontal * movementSpeed * Time.deltaTime;
        transform.position = position;
    }
}
