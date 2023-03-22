using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum State
{
    Done,
    WIP,
    Cancel
}
public class MyEnumPract : MonoBehaviour
{
    State myState;

    void Start()
    {
        myState = State.Done;

        switch (myState)
        {
            case State.Done: 
                Debug.Log(State.Done + " " +(int)State.Done);
                break;

            case State.WIP:
                Debug.Log((int)State.WIP);
                break;
            case State.Cancel:
                 Debug.Log((int)State.Cancel);
                 break;

        }

        if (myState == State.Done) 
        {
            Debug.Log(State.Done + " " + (int)State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.WIP);
        }
        else
        {
            Debug.Log(State.Cancel);
        }
    }
    
    void Update()
    {
        
    }
}
