using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public int currentHealth = 3;
    private int lastHealth = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (currentHealth == lastHealth)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
            else
            {
                currentHealth--;
            }
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
