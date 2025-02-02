﻿using UnityEngine;

public class EquipmentState : BaseState
{
    private InputValues playerInputValues;

    public EquipmentState(InputValues playerInputValues)
    {
        this.playerInputValues = playerInputValues;
    }

    public override void EnterState()
    {
        GUIController.Instance.OpenInventory(playerInputValues.Owner);
    }

    public override void ExitState()
    {
        GUIController.Instance.OpenInventory(playerInputValues.Owner);
    }

    public override void StateUpdate()
    {
        if (playerInputValues.Pause == ButtonState.Down)
        {
            StateManager.Instance.ExitCurrentState();
        }
    }
}