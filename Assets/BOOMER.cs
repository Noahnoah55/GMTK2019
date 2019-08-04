using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOMER : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] sprites;
    int currentsprite = 0;
    void Start()
    {
        InvokeRepeating("NextSprite",1f/30f,1f/30f);
    }

    // Update is called once per frame
    void NextSprite()
    {
        if (currentsprite < sprites.Length)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[currentsprite];
            currentsprite ++;
        }
    }
}
