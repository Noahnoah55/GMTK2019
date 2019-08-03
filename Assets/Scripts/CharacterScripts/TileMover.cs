using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TileMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool checkMove(Vector2 direction)
    {
        return checkSpace(new Vector2(transform.position.x + direction.x, transform.position.y + direction.y), "Blocker");
    }

    public static bool checkSpace(Vector2 position, string targetTag)
    {
        Collider2D[] collisions = Physics2D.OverlapPointAll(position);
        bool answer = true;
        foreach (Collider2D collision in collisions)
        {
            if (Array.Exists(collision.GetComponent<Tagger>().tags, tag => tag == targetTag)){answer = false;}
        }
        return answer;
    }

    public static List<Collider2D> getCollidersWithTag(Vector2 position, string targetTag)
    {
        List<Collider2D> answer = new List<Collider2D>();
        Collider2D[] collisions = Physics2D.OverlapPointAll(position);
        foreach (Collider2D collision in collisions)
        {

            if (Array.Exists(collision.GetComponent<Tagger>().tags, tag => tag == targetTag)){answer.Add(collision);}
        }
        return answer;
    }

    public bool attemptMove(Vector2 direction) // direction should only be 1 unit up, down, left, or right
    {
        if (checkMove(direction))
        {
            transform.Translate(direction);
            return true;
        }
        else {return false;}
    }
}
