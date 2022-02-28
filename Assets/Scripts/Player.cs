using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int playerHealth = 1;
    public static bool hasKeys, hasPhone, hasWallet, win, isDead;
   
    public float playerSpeed = 2.0f;
    public int numItems = 0;
    public Text total;
    public AudioSource SFX; 


    //Rigidbody rigidbody;
    Animator playerAnimator;

    //Movement ref
    Vector2 inputVector = Vector2.zero;
    Vector3 moveDirection = Vector3.zero;

    public readonly int movementXHash = Animator.StringToHash("MovementX");
    public readonly int movementYHash = Animator.StringToHash("MovementY");

    private void Awake()
    {
        //rigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        SFX = GetComponent<AudioSource>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        hasKeys = false;
        hasPhone = false;
        hasWallet = false;
        win = false;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(inputVector.magnitude > 0)) moveDirection = Vector3.zero;

        moveDirection = transform.forward * inputVector.y + transform.right * inputVector.x;
        
        Vector3 movementDirection = moveDirection * (playerSpeed * Time.deltaTime);
        transform.position += movementDirection;

        if(isDead)
        {
            print("you died");
            SceneManager.LoadScene("Death"); 
        }

        if(numItems == 3)
        {
            print("done");
            SceneManager.LoadScene("Win"); 
        }

        total.text = numItems.ToString(); 
    }

    public void OnMovement(InputValue input)
    {
        inputVector = input.Get<Vector2>();
        playerAnimator.SetFloat(movementXHash, inputVector.x);
        playerAnimator.SetFloat(movementYHash, inputVector.y);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "DeathPlaneSky" || collision.gameObject.tag == "DeathPlane")
        {
            isDead = true;
        }
        else if(collision.gameObject.tag == "Phone")
        {
            SFX.Play(); 
            numItems++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Bag")
        {
            SFX.Play();
            numItems++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Keys")
        {
            SFX.Play();
            numItems++;
            Destroy(collision.gameObject);
        }
    }


}
