using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{
   
    [SerializeField] protected SpriteRenderer _renderer;
    [SerializeField] private GameObject _highLight;
    // Start is called before the first frame update
   public virtual void Init(int x, int y)
    {
      
    }

    void OnMouseEnter()
    {
        _highLight.SetActive(true);
    }
    void OnMouseExit()
    {
        _highLight.SetActive(false);
    }
 
}
