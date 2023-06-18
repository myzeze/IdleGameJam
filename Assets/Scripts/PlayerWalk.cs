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
        float speed = Input.GetAxis("Vertical");

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);

        CharacterController controller = GetComponent<CharacterController>();
        controller.SimpleMove(forward * speed * moveSpeed);

        /*if (speed != 0)
        {
            Debug.Log(speed);
        }*/
    }

}
