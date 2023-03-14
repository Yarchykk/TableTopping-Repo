using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmanager : MonoBehaviour
{

    //https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev video for creating grid in unity 2:20 in
    [SerializedField] private int _width, _height;

    [SerializedField] private Tile _tilePrefab;

    void Start(){
        GenerateGrid();
    }

    void GenerateGrid{
        for(int x = 0; x < _width; x++){
        for(int y = 0; y < _height; y++){
            var spawnedTile = instantiate(_tilePrefab, new Vector3(x,z), Quaternion.identity);
            spawnedTile.name = $"Tile {x} {y}";
        }
    }
    }
    
}
