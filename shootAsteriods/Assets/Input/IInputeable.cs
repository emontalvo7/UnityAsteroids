using UnityEngine;

public interface IInputeable
{
    void ShotPressed();
    //void GetHorizontalAxis(float value);
    //void GetVerticalAxis(float value);
    void GetDirection(Vector3 direccion);
}
