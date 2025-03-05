using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
    
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] private Vector3 jump;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform indicate;




    void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();

        jump = new Vector3(0.0f, 2.0f, 0.0f);




    }
    private void MovePlayer(Vector2 direction)
    {
        Vector3 forward = indicate.forward;
        Vector3 right = indicate.right;

        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * direction.y + right * direction.x;
        rb.AddForce(speed * moveDirection);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
