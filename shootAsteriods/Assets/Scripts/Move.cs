using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    public void Update()
    {
        Vector3 up = new Vector3(0, 1f, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }
    //public void DoMove(Vector3 moverValue)
    //{
    //    transform.Translate(moverValue);
    // }
}
