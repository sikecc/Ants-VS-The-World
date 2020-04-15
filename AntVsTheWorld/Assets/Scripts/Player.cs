using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    //NEW
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;

    private Vector3 moveDirection = Vector3.zero;

    //NEW
    private Vector2 rotation = Vector2.zero;
    public bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rotation.y = transform.eulerAngles.y;
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            float curSpeedX = canMove ? speed * Input.GetAxis("Vertical") : 0;
            float curSpeedY = canMove ? speed * -Input.GetAxis("Horizontal") : 0;
            moveDirection = (forward * curSpeedY) + (right * curSpeedX);

            if (Input.GetButton("Jump") && canMove)
            {
                moveDirection *= jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        //NEW
        if (canMove)
        {
            rotation.y += Input.GetAxis("Mouse X") * lookSpeed;
            rotation.x += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotation.x = Mathf.Clamp(rotation.x, -lookXLimit, lookXLimit);
            transform.eulerAngles = new Vector2(0, rotation.y);
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit collision)
    {

        if (collision.gameObject.tag == "Fruit")
        {
            var health = gameObject.GetComponent<Health>();
            health.AddHealth(10);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "NPC")
        {
            var health = gameObject.GetComponent<Health>();
            health.TakeDamage(20);
        }
    }
}
