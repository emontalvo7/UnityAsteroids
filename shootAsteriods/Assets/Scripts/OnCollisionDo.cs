using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionDo : MonoBehaviour
{
    [SerializeField] private UnityEvent action;
    private GameObject collisiones;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisiones = collision.gameObject;
        action.Invoke();
    }
    public void DestroyCollosioner() {
        if (collisiones != null) {
            Destroy(collisiones);
        }
    }
}
