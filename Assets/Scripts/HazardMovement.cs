using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 1;
    private bool switched = false;

    public Rigidbody2D myRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collision!");
        if (!switched)
        {
            switched = true;
        } else
        {
            switched = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!switched)
        {
            myRigidBody.velocity = Vector2.right * speed;
        } else if (switched)
        {
            myRigidBody.velocity = Vector2.left * speed;
        }
        
    }
}
