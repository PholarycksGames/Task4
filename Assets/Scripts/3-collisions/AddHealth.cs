using UnityEngine;

public class AddHealth : MonoBehaviour
{
    [SerializeField] PlayerDestroyOnTrigger2D destroyOnTrigger2DScript;
    private int healthAdded = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        destroyOnTrigger2DScript.currentHealth += healthAdded;
        Destroy(gameObject);
    }
}

