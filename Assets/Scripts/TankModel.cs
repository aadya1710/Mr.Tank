﻿
using UnityEngine;

public class TankModel 
{
    private TankControl tankControl;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material color;

    public TankModel(float _movement,float _rotation, TankTypes tank,Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = tank;
        color = _color;
    }
    public void SetUpTankController(TankControl _tankControl)
    {
        tankControl = _tankControl;
    }
}
