using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stepsound;
    public GameObject clapsound;
    public GameObject yeehaw;
    public AudioClip[] sounds;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playsound(string sound)
    {
        if (sound == "step") 
        {
            stepsound.GetComponent<AudioSource>().pitch = Random.value + .5f;
            stepsound.GetComponent<AudioSource>().Play();
        }
        else if (sound == "clap") 
        {
            clapsound.GetComponent<AudioSource>().pitch = Random.value + .5f;
            clapsound.GetComponent<AudioSource>().Play();
        }
        else if (sound == "victory")
        {
            yeehaw.GetComponent<AudioSource>().PlayOneShot(sounds[Random.Range(0,sounds.Length)]);
        }
    }
}
