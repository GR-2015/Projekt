﻿using UnityEngine;
using System.Collections;

public abstract class BaseBehavior : MonoBehaviour 
{
    protected EnemyController _controlledEnemy;

    [SerializeField]
    private int priority = 1;

    public int Priority { get { return priority; } } 

    [SerializeField]
    protected bool overloadPermission = false;

    public bool OverloadPermission { get { return overloadPermission; } }

    private void Awake()
    {
        _controlledEnemy = GetComponent<EnemyController>();
    }

    public abstract bool EntryConditions();

    public abstract void Behavior();

    public abstract void OverloadConditions();

}
