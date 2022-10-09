using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2 : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;
    [SerializeField] private float _tileSize;

    [SerializeField] private Transform _cam;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; x++)
            {
                var SpawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                SpawnedTile.name = $"Tile{x},{y}";
                var isOffset = (x % 2 == 0&& y% 2!=0) || (x % 2 != 0 && y % 2 == 0);
                SpawnedTile.Init(isOffset);
            }
        }
        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

    }
}
