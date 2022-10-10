using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Character  character;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(character.attackPoints);
    }


}
