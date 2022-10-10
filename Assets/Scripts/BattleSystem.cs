using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum BattleState {START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public GameObject Soldier1;
    
    public GameObject Soldier2;
    public GameObject Hero;

    public Transform initSoldier1;
    public Transform initSoldier2;
    public Transform initHero;

    public Soldier playerSoldier1;
    public Transform soldier1Transform;
    public Transform soldier2Transform;
    public Transform heroTransform;

    //Hero playerHero;

    public BattleState state;
    // Start is called before the first frame update
    public void Start()
    {
        playerSoldier1 = Soldier1.GetComponent<Soldier>();
        soldier1Transform = Soldier1.GetComponent<Transform>();
        soldier2Transform = Soldier2.GetComponent<Transform>();
        heroTransform = Hero.GetComponent<Transform>();

        state = BattleState.START;
        SetupBattle();
    }

   public void SetupBattle()
    {
        soldier1Transform.position = initSoldier1.transform.position;
        soldier2Transform.position = initSoldier2.transform.position;
        heroTransform.position = initHero.transform.position;

        /*GameObject Soldier1GO =  Instantiate(SoldierPrefab, initSoldier1);
        playerSoldier1 = Soldier1GO.GetComponent<Soldier>();

        GameObject Soldier2GO = Instantiate(SoldierPrefab, initSoldier2);
        playerSoldier2 = Soldier2GO.GetComponent<Soldier>();

        GameObject HeroGO = Instantiate(HeroPrefab, initHero);
        playerHero = HeroGO.GetComponent<Hero>();
       //Debug.Log(playerHero.character.defensePoints);*/
        state = BattleState.PLAYERTURN;
    }
   /* IEnumerator PlayerAttack()
    {

    }*/

    public void Attack()
    {
        if (state != BattleState.PLAYERTURN)
            return;
       // StartCoroutine(PlayerAttack());
        Debug.Log("is attacking");
        Debug.Log(playerSoldier1.character.name);
    }
    public void Move()
    {
        Debug.Log("is moving");
    }
}
