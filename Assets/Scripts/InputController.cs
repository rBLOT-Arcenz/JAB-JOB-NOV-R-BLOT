using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public CharacterController controller;
    public GameObject first;
    public GameObject third;
    public GameObject third2;

    public GameObject boule;
    public Transform boulePos;

    public GameObject head;

    public float mouseSensitivity = 100f;
    public float speed = 2f;
    public float gravity = -9.81f;

    float xRotation = 0f;

    public bool Key = false;

    Vector3 velocity;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            if (first.activeSelf)
            {
                third2.SetActive(false);
                third.SetActive(true);
                head.SetActive(true);
                first.SetActive(false);
            }
            else if (third.activeSelf)
            {
                third2.SetActive(true);
                third.SetActive(false);
                head.SetActive(true);
                first.SetActive(false);
            }
            else if (third2.activeSelf)
            {
                third2.SetActive(false);
                third.SetActive(false);
                head.SetActive(false);
                first.SetActive(true);
            }
        }

        if (first.activeSelf)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            first.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * -z + transform.forward * x;

            controller.Move(move * speed * Time.deltaTime);
        }
        

        else if (third.activeSelf || third2.activeSelf)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * speed);


            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            var newBoule = Instantiate(boule, boulePos.position, transform.rotation);
            newBoule.GetComponent<Rigidbody>().velocity = transform.forward * 20;

        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("THIS IS THE END");
        if (c.gameObject.tag == "END")
        {

        }
    }

}