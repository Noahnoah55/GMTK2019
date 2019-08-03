using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EndCondition : MonoBehaviour
{

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

        }
    }
}
