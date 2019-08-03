using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Switch : MonoBehaviour
{
    // MUST SET DotLayer, OnTile, and OffTile
    Tilemap tm;
    public Tilemap DotLayer;
    public TileBase OnTile;
    public TileBase OffTile;
    bool isSwitchOn = false;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hitSwitch()
    {
        if (isSwitchOn)
        {
            tm.SwapTile(OnTile,OffTile);
            isSwitchOn = false;
        }
        else
        {
            tm.SwapTile(OffTile,OnTile);
            isSwitchOn = true;
        }
        DotLayer.GetComponent<Switcher>().ChangeBlocks();
    }
}
