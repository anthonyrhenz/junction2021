using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobUpDown : MonoBehaviour
{
    // Update is called once per frame
    //adjust this to change speed
    [SerializeField]
    float speed = 5f;
    //adjust this to change how high it goes
    [SerializeField]
    float height = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        
    }
 
    void Update() {
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
