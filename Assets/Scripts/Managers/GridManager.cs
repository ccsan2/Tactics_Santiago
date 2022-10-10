using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2 : MonoBehaviour
{

    public static Grid2 Instance;
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tileColina, _tilemar, _tileMontaña;
    [SerializeField] private float _tileSize;

    [SerializeField] private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; x++)
            {
                var _randomTile = Random.Range(0, 6) == 3 ? _tileMontaña : _tileColina ;
               

                var SpawnedTile = Instantiate(_randomTile, new Vector3(x, y), Quaternion.identity);
                SpawnedTile.name = $"Tile{x},{y}";
                
                SpawnedTile.Init(x,y);

                _tiles [new Vector2 (x, y)] = SpawnedTile;
            }
        }
        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

    }

    GameManager.Instance.ChangeState(SpawnHeroes);

    public  Tile GetTilePosition(Vector2 pos)
    {
        if (_tiles.TryGetValue (pos, out Tile tile))
        {
            return tile;
        }
        return null;    
    }
}
