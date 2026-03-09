using UnityEngine;

// Should probably delete this script

public class CameraController : MonoBehaviour
{

    //reference to the game object
    public GameObject seed;
    //distance between camera and player
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //to calc intial offset between the camera's position and he player position 
        offset = transform.position - seed.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Maintain the same offset between the camera and player throughout the game.
        transform.position = seed.transform.position;
        
    }
}
