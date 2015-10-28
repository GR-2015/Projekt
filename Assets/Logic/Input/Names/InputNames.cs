﻿using UnityEngine;

public class InputNames : MonoBehaviour
{
    [SerializeField]
    private string _movementXaxis = "MovementXaxis";

    [SerializeField]
    private string _movementYaxis = "MovementYaxis";

    [SerializeField]
    private string _jumpButton = "Jump";


    public string MovementXaxis
    {
        get { return _movementXaxis; }
    }

    public string MovementYaxis
    {
        get { return _movementYaxis; }
    }

    public string JumpButton
    {
        get { return _jumpButton; }
    }
}