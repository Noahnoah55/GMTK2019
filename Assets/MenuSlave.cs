using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSlave : MonoBehaviour
{
    public GameObject eatshort;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            if (eatshort.activeSelf)
            {
                eatshort.SetActive(false);
            }
            else
            {
                eatshort.SetActive(true);
            }
        }
        if (Input.GetButtonDown("restart"))
        {
            RestartLevel();
        }
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
