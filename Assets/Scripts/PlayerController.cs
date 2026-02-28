using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public CharacterController controller;
    
    public float speed = 5.0f;
    public float rotateSpeed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.wKey.isPressed)
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, 1.0f * Time.deltaTime * speed);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
        }
        if (keyboard.sKey.isPressed)
        {
            Vector3 movement = new Vector3(0.0f, 0.0f, -1.0f * Time.deltaTime * speed);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
        }
        if (keyboard.aKey.isPressed)
        {
            Vector3 movement = new Vector3(-1.0f * Time.deltaTime * speed, 0.0f, 0.0f);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
            //Vector3 rotation = new Vector3(0.0f, -1.0f * Time.deltaTime * rotateSpeed, 0.0f);
            //transform.Rotate(rotation);
        }
        if (keyboard.dKey.isPressed)
        {
            Vector3 movement = new Vector3(1.0f * Time.deltaTime * speed, 0.0f, 0.0f);
            movement = transform.TransformDirection(movement);
            controller.Move(movement);
            //Vector3 rotation = new Vector3(0.0f, 1.0f * Time.deltaTime * rotateSpeed, 0.0f);
            //transform.Rotate(rotation);
        }
        if (keyboard.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
    }
}
