using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public Character  character;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(character.attackPoints);
    }

}
