using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();


    void Update()
    {
        Vector2 input = Vector2.zero;

        Vector3 input2 = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            input += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input += Vector2.right;
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            input += Vector2.up;
            input = input * 2;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            input += Vector2.down;
            input = input * 2;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            input += Vector2.left;
            input = input * 2;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            input += Vector2.right;
            input = input * 2;
        }
        OnMove?.Invoke(input);

    }
    
}
