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

    public Vector2 rotateFace(Vector2 direction, string newdir)
    {
        print(direction);
        if (newdir == "left")
        {
        if (direction == Vector2.up) {changeFace(Vector2.left); return Vector2.left;}
        if (direction == Vector2.left) {changeFace(Vector2.down); return Vector2.down;}
        if (direction == Vector2.down) {changeFace(Vector2.right); return Vector2.right;}
        if (direction == Vector2.right) {changeFace(Vector2.up); return Vector2.up;}
        }
        else if (newdir == "right")
        {
        if (direction == Vector2.left) {changeFace(Vector2.up); return Vector2.up;}
        if (direction == Vector2.down) {changeFace(Vector2.left); return Vector2.left;}
        if (direction == Vector2.right) {changeFace(Vector2.down); return Vector2.down;}
        if (direction == Vector2.up) {changeFace(Vector2.right); return Vector2.right;}
        }
        return direction;
    }
}
