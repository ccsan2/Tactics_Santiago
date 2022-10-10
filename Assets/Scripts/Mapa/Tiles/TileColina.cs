using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColina : Tile
{
    [SerializeField] private Color _basecolor, _offsetcolor;

    public override void Init(int x, int y)
    {
        var isOffset = (x+y)%2==1;
        _renderer.color = isOffset ? _offsetcolor : _basecolor;
    }
}
  