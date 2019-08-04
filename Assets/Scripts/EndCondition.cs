using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EndCondition : MonoBehaviour
{
    bool screenshown = false;
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Shooter>().Enemies.Length == 0)
        {
            endscreen.SetActive(true);
            if (screenshown != true)
            {
                GetComponent<SoundManager>().playsound("victory");
                print("win");
                screenshown = true;
            }
        }
    }
}
