using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoHolder : MonoBehaviour
{
    public bool isCarryingAmmo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireGun(Vector2 direction)
    {
        if (isCarryingAmmo) {isCarryingAmmo = false; GetComponent<Shooter>().fireShot(direction);}
    }

    public void pickupAmmo()
    {
        isCarryingAmmo = false;
    }
}
