using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents;


public class Example : MonoBehaviour
{
    // The void event could be IntegerEvent, Vector3Event, FloatEvent etc... 
    [SerializeField] private VoidEvent onGameStarted;
    [SerializeField] private IntegerEvent onScoreChanged;
    [SerializeField] private int m_TestValue = 1;

    private void Start()
    {
        if (onGameStarted)
        {
            // This is how you call the game event.
            onGameStarted.Raise();
        }
        if (onScoreChanged)
        {
            // If this was another parameter type, you could test the value like so  
            onScoreChanged.Raise(m_TestValue);
        }
        // It's that simple. 
    }
}