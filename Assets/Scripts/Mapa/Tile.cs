using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _basecolor, _offsetcolor;
    [SerializeField] private SpriteRenderer _renderer;
    // Start is called before the first frame update
   public void Init(bool isoffset)
    {
        _renderer.color =isoffset ?  _offsetcolor : _basecolor;
    }
}
