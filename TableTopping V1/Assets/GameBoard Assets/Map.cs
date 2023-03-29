using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject hexTilePrefab;

    //Size of map in hex tiles
    int width = 20;
    int height = 20;

    //Hexoffset
    float xOffSet;
    float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Instantiate(hexTilePrefab, new Vector3(x,0,y), Quaternion.identity);
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
