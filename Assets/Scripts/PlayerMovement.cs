using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables etc.
    public float speed = 10;
    public float runSpeed = 20;
    public float turnSpeed = 250;
    public float jumpHeight = 25;

    private float _HorizontalInput;
    private float _VerticalInput;
    private bool _HasVerticalInput;
    private bool _HasHorizontalInput;
    private bool _HasShift;
    private bool _isRunning;
    private Animator _playerAnim;

    //Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //Sets up bools for Player input
        _HorizontalInput = Input.GetAxis("Horizontal");
        _VerticalInput = Input.GetAxis("Vertical");
        

        _HasHorizontalInput = !Mathf.Approximately(_HorizontalInput, 0f);
        _HasVerticalInput = !Mathf.Approximately(_VerticalInput, 0f);
        _HasShift = Input.GetKey(KeyCode.LeftShift);
        
        //Sets Walk and Run animations when input is given
        if (_HasVerticalInput)
        {
            _playerAnim.SetInteger("MoveState", 1);
        }
        else
        {
            _playerAnim.SetInteger("MoveState", 0);
        }
        if (_HasShift && _HasVerticalInput)
        {
            _playerAnim.SetInteger("MoveState", 2);
            transform.Translate(Vector3.forward * _VerticalInput * Time.deltaTime * runSpeed);
            /*if(Stamina >= 0)
            {
                transform.Translate(Vector3.forward * _VerticalInput * Time.deltaTime * runSpeed);
                _isRunning = true;
            } 
            else
            {
                _playerAnim.SetInteger("MoveState", 1);
                transform.Translate(Vector3.forward * _VerticalInput * Time.deltaTime * speed);
                _isRunning = false;
            }*/

        }
        else
        {
            transform.Translate(Vector3.forward * _VerticalInput * Time.deltaTime * speed);
        }
        transform.Rotate(Vector3.up, _HorizontalInput * turnSpeed * Time.deltaTime);

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up *jumpHeight * Time.deltaTime);
            _playerAnim.SetTrigger("Jump");
            _isJumping = true;            
        }
    
        if (_playerAnim.GetCurrentAnimatorStateInfo(0).IsName("Jump") && _isJumping)
        {
            _isJumping = false;
        }*/
    }


    void Update()
    {
        
    }
}
