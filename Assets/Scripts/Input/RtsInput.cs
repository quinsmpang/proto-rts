﻿using UnityEngine;
public abstract class RtsInput : MonoBehaviour
{
    public abstract bool IsQuitting();    
    public abstract bool IsSelectionStarted();
    public abstract bool IsSelectionFinished();
    public abstract Vector2 GetSelectionPosition();
    public abstract bool IsActionTriggered();
    public abstract Vector2 GetActionPosition();
    public abstract bool IsPanning();

    public abstract float GetSpeedX();

    public abstract float GetSpeedY();

    public abstract float GetSpeedZ();
}
