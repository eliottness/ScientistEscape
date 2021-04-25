using Platformer.View;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DeleteFire : MonoBehaviour
{
    private Tilemap tiles;
    public float randomDelayAnim = 20f;
    
    // Start is called before the first frame update
    void Awake()
    {
        tiles = GetComponent<Tilemap>();
    }

    public void DeleteTile(Vector3Int point)
    {
        tiles.SetTile(point, null);
    }
}
