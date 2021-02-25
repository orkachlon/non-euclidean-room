using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public string horizontalInputName = "Horizontal";
    public string verticalInputName = "Vertical";
    public float movementSpeed = 6.0f;
    public AnimationCurve jumpFallOff;
    public float jumpMultiplier = 10.0f;
    public float gravity = 9.8f;
    public KeyCode jumpKey = KeyCode.Space;

    private CharacterController charContoller;
    private bool isJumping;

    // Start is called before the first frame update
    void Awake()
    {
        charContoller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
        {
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;
        Vector3 vel = forwardMovement + rightMovement;
        vel.y -= gravity;

        charContoller.Move(vel * Time.deltaTime);
        JumpInput();
    }

    private void JumpInput()
    {
        if (Input.GetKeyDown(jumpKey) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(JumpEvent());
        }
    }

    private IEnumerator JumpEvent()
    {
        charContoller.slopeLimit = 90.0f;
        float timeInAir = 0.0f;

        do
        {
            float jumpForce = jumpFallOff.Evaluate(timeInAir);
            charContoller.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!charContoller.isGrounded && charContoller.collisionFlags != CollisionFlags.Above);

        charContoller.slopeLimit = 45.0f;
        isJumping = false;
    }

    public Tuple<int, int> CurrentRoom()
    {
        float xValue = transform.position.x, zValue = transform.position.z;
        int room, section ;

        // Get room number
        if (Mathf.Abs(xValue) < 15)
            room = 0;
        else if (-15 + 32 < xValue && xValue < 15 + 32)
            room = 1;
        else if (-15 + 64 < xValue && xValue < 15 + 64)
            room = 2;
        else if (-15 + 96 < xValue && xValue < 15 + 96)
            room = 3;
        else
            room = 4;

        // Get section number
        if (Mathf.Abs(zValue) < 15)
            section = 0;
        else if (-15 + 32 < zValue && zValue < 15 + 32)
            section = 1;
        else if (-15 + 64 < zValue && zValue < 15 + 64)
            section = 2;
        else if (-15 + 96 < zValue && zValue < 15 + 96)
            section = 3;
        else
            section = 4;

        return new Tuple<int, int>(room, section);
    }
}
