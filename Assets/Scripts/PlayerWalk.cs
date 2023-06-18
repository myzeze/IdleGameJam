using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    [Header("Player Variables")]
    public float moveSpeed = 4.0f;
    public float rotateSpeed = 1.5f;

    void Start()
    {
        Debug.Log("player ACTUALLY works");
    }

    void Update()
    {
        //going forward
        float speed = Input.GetAxis("Vertical");

        //rotation in regards to the a d keys
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);

        //WHAT
        CharacterController controller = GetComponent<CharacterController>();
        controller.SimpleMove(forward * speed * moveSpeed);

    }

}
