using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 8f;
    public float moveSpeed = 8f;

    private Rigidbody rbody;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        transform.Translate(movement * Time.deltaTime * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {            
            isJumping = true;
            rbody.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}
