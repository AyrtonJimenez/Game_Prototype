using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Transform Player;
    private Animator _enemy1Anim;

    private bool _isAttacking;
    public bool _isStopped;
    private float WalkSpeed = 5f;
    private float RunSpeed = 15f;
    private float Distance;
    //private float time = 0.0f;

    void Start()
    {    
        _enemy1Anim = GetComponent<Animator>();
        //_enemy1Anim.SetInteger("MoveState", 0);
        _isAttacking = false;
        _isStopped = false;
    }

    void Update()
    {
        Distance = Vector3.Distance(transform.position, Player.transform.position);
        transform.LookAt(Player);
        if (_isAttacking)
        {
            if (Distance >= 20)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.position, RunSpeed * Time.deltaTime);
                _enemy1Anim.SetInteger("MoveState", 2);
                Debug.Log("Running");
            }
            if (Distance <=5 && Distance > 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.position, WalkSpeed / Distance * Time.deltaTime);
                _enemy1Anim.SetInteger("MoveState", 1);
                Debug.Log("Walking");
                _isStopped = false;
            }
            else
            {
                _enemy1Anim.SetInteger("MoveState", 0);
                Debug.Log("Stopped");
                _isStopped = true;
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _isAttacking = true;
            Debug.Log("Enemy Alerted");
        }
    }
}
