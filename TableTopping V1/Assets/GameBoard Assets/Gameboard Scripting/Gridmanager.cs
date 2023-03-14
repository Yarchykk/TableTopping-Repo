using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmanager : MonoBehaviour
{

    //https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev video for creating grid in unity 2:20 in
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

    void Start(){
        GenerateGrid();
    }

    void GenerateGrid(){
        for(int x = 0; x < _width; x++){
            for(int y = 0; y < _height; y++){
                var spawnedTile = instantiate(_tilePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
            }
        }
    }
    
}
