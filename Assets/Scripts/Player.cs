using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static int playerHealth = 1;
    public static bool hasKeys, hasPhone, hasWallet, win;
   
    public float playerSpeed = 2.0f;

    Rigidbody rigidbody;
    Animator playerAnimator;

    //Movement ref
    Vector2 inputVector = Vector2.zero;
    Vector3 moveDirection = Vector3.zero;

    public readonly int movementXHash = Animator.StringToHash("MovementX");
    public readonly int movementYHash = Animator.StringToHash("MovementY");
    public readonly int pickUpHash = Animator.StringToHash("PickUp");

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        hasKeys = false;
        hasPhone = false;
        hasWallet = false;
        win = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!(inputVector.magnitude > 0)) moveDirection = Vector3.zero;

        moveDirection = transform.forward * inputVector.y + transform.right * inputVector.x;
        
        Vector3 movementDirection = moveDirection * (playerSpeed * Time.deltaTime);
        transform.position += movementDirection;

    }

    public void OnMovement(InputValue input)
    {
        inputVector = input.Get<Vector2>();
        playerAnimator.SetFloat(movementXHash, inputVector.x);
        playerAnimator.SetFloat(movementYHash, inputVector.y);
    }

   
}
