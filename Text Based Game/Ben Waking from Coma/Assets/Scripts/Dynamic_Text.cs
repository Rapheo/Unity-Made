using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic_Text : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    [SerializeField] int DevPass;
    [SerializeField] InputField stateDevInput;
    [SerializeField] GameObject InputField;

    State state;
    DevState devState;
    bool runManage = true;
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }


    void Update()
    {
        DevManage();
        ManageState();
    }

    private void ManageState()
    {
        if (runManage)
        {
            var nextState = state.GetNextState();
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                state = nextState[0];
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                if (nextState[1] != null)
                {
                    state = nextState[1];
                }
                else
                {
                    Debug.Log("No State");
                }
            }
            textComponent.text = state.GetStateStory();
        }
    }

    private void DevManage()
    {
        if (DevPass == 9252)
        {
            runManage = false;
            InputField.SetActive(true);
            int stateDevInputint;
            stateDevInputint = int.Parse(stateDevInput.text);
            State[] nextDevState = devState.GetNextDevState();
            state = nextDevState[stateDevInputint];
            textComponent.text = state.GetStateStory();
        }
        else {
            InputField.SetActive(false);
            runManage = true;
        }
    }
}
