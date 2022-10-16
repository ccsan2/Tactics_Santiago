using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MoveCommand : Command
{
    Vector3 target;
    Character character;

    public MoveCommand(Character rgmt, Vector3 trgt)
    {
        character = rgmt;
        target = trgt;
    }
    protected override async Task AsyncExecuter()
    {
        while (character.transform.position != target)
        {
            character.transform.position = Vector3.MoveTowards(character.transform.position,target,0.05f);
            await Task.Delay(20);
        }
    }
}
