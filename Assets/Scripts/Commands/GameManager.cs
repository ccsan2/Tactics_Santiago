using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character selectedCharacter;

    public Command activeCommand;

    Queue<Command> commandQueue = new Queue<Command>(); 
    void Start()
    {
        activeCommand = new MoveCommand(selectedCharacter, selectedCharacter.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 target =Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z=0;
            commandQueue.Enqueue(new MoveCommand(selectedCharacter,target));
        }
        if (!activeCommand.IsExecuting && commandQueue.Count > 0)
        {
            activeCommand=commandQueue.Dequeue();
            activeCommand.Execute();
        }
    }
}
