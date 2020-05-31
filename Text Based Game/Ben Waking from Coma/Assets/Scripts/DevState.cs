using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DevState")]

public class DevState : ScriptableObject
{
    [SerializeField] State[] nextDevState;

    public State[] GetNextDevState()
    {
        return nextDevState;
    }
}
