using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset = new Vector3(0, 2, -2);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {     
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
        transform.Rotate(25f, 0f, 0f);
        transform.Translate(Vector3.back + _offset);
    }
}