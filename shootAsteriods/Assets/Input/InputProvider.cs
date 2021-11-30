using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputProvider
{
    public delegate void HasShoot();
    public static event HasShoot OnHasShot;


    public delegate void Direction(Vector3 direction);
    public static event Direction OnDirection;
    public static void TriggerOnHasShoot()
    {
        OnHasShot?.Invoke();
    }

    public static void TriggerDirection(Vector3 direction)
    {
        OnDirection?.Invoke(direction);
    }
 
}
