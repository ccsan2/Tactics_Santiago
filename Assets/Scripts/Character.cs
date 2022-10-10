using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    public int actionPoints;
    public float health;
    public float attackPoints;
    public float defensePoints;

    public void attack ()
    {
        Debug.Log("atacarrrrrrr");
    }
}
