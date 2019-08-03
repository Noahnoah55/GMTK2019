using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    Sprite defaultsprite;
    public Sprite hoversprite;
    public string firstlevelname;
    SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        defaultsprite = spr.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        spr.sprite = hoversprite;
    }

    void OnMouseExit()
    {
        spr.sprite = defaultsprite;
    }

    void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(firstlevelname);
    }
}
