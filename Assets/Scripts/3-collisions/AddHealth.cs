using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    [SerializeField] DestroyOnTrigger2D destroyOnTrigger2DScript;
    private int healthAdded = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        destroyOnTrigger2DScript.health += healthAdded;
        Destroy(gameObject);
    }
}

