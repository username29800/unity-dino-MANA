using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector2 dir;
    
    public float gravity = 9.8f * 2f;
    public float jumpForce = 8f;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        dir = Vector2.zero;
    }

    private void Update()
    {
        dir += Vector2.down * gravity * Time.deltaTime;

        if (character.isGrounded)
        {
            dir = Vector2.down;
            if (Input.GetButtonDown("Jump"))
            {
                dir = Vector2.up * jumpForce;
            }
        }

        character.Move(dir * Time.deltaTime);
    }
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
