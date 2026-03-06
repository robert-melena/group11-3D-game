using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //rotate object on x,y, and z axez by specified amounts, adjusted for frame rate
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
        
    }
}
