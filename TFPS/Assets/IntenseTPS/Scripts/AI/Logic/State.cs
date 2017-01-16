﻿using StateSystems;
/// Used to execute <see cref="AIStateSystem"/>'s
/// </summary>
public abstract class State
    protected AIStateSystem[] sSystems;
    public ET.StateType StateType { get; protected set; }
    {
        sSystems = _stateSystems;
    }

    public virtual void EnterState(AIBrain ai)
    {
        foreach (var sSystem in sSystems)
            sSystem.OnActionActivate(ai, StateType);
    }

    {
        foreach (var sSystem in sSystems)
            sSystem.OnUpdate(ai, StateType);
    }

    {
        foreach (var sSystem in sSystems)
            sSystem.OnActionExit(ai, StateType);
    }
    {
        foreach (var sSystem in sSystems)
            sSystem.OnAnimatorIK(ai, layerNo, StateType);
    }

    {
        foreach (var sSystem in sSystems)
            sSystem.OnAnimatorMove(ai, StateType);
    }