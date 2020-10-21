using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float scrollspeed; // how much speed an object should move
    public Vector2 startpos; // the starting position of the object

    // use this for initialization
    void Start()
    {
        startpos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollspeed, 28); // Create a new position by using the scroll speed.
        transform.position = startpos + Vector2.right * newPos; // set the new location for the object and set a distance until it goes back to starting postion
    }
}
