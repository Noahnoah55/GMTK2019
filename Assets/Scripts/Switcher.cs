using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Switcher : MonoBehaviour
{
    // Set all of these TileBases in editor
    public TileBase OnWall;
    public TileBase OffWall;
    public TileBase TempWall;
    Tilemap tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBlocks()
    {
        tm.SwapTile(OffWall,TempWall);
        tm.SwapTile(OnWall,OffWall);
        tm.SwapTile(TempWall,OnWall);
    }
}
