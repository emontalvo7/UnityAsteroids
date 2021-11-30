using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMinimun, xMaximun, yMinimum, yMaximun;
}

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Move moverComponente;
    public float speed = 1f;
    public Boundary boundary;
    public Transform shotOrigin;
    public GameObject shootPrefab;

    public void Start()
    {
        moverComponente.speed = speed;
        InputProvider.OnHasShot += OnHasShoot;
        InputProvider.OnDirection += OnDirection;
    }
    private void OnDirection(Vector3 direction)
    {
        moverComponente.direction = direction;
    }

    private void OnHasShoot() {
        Instantiate(shootPrefab, shotOrigin, false);

    }
    void Update()
    {
        //Vector3 desplazamiento = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),transform.position.z);
        //moverComponente.direction = desplazamiento;
        // x = -8.7
        // y = 4.5
        float x = Mathf.Clamp(transform.position.x, boundary.xMinimun, boundary.xMaximun);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximun);
        transform.position = new Vector3(x, y);
    }
}
