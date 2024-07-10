using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    static public bool visibile;
    Rigidbody rb;

    [Header("Movement")]
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 100;
    public float moveSpeed = 5;

    [Header("Crouching")]
    public float crouchspeed;
    public float crouchYScale;
    private float startYScale;

    [Header("Keybinds")]
    public KeyCode crouchKey = KeyCode.LeftShift;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startYScale = transform.localScale.y;
        visibile = true;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * moveSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        //accucciarsi
        if(Input.GetKeyDown(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, crouchYScale, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            moveSpeed = crouchspeed;

        }

        //in piedi
        if (Input.GetKeyUp(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            moveSpeed = crouchspeed * 2f;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            moveSpeed = 0;
            turnSpeed = 0;
            visibile = false;
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            moveSpeed = 5;
            turnSpeed = 100;
            visibile = true;
        }
    }
}
