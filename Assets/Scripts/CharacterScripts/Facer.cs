using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facer : MonoBehaviour
{
    public Sprite upfacing;
    public Sprite downfacing;
    public Sprite rightfacing;
    public Sprite leftfacing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeFace(Vector2 direction)
    {
        if (direction == Vector2.up) {GetComponent<SpriteRenderer>().sprite = upfacing;}
        if (direction == Vector2.down) {GetComponent<SpriteRenderer>().sprite = downfacing;}
        if (direction == Vector2.left) {GetComponent<SpriteRenderer>().sprite = leftfacing;}
        if (direction == Vector2.right) {GetComponent<SpriteRenderer>().sprite = rightfacing;}
    }

    public void rotateFace(Vector2 direction)
    {
    }
}
