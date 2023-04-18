using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public int startingHealth = 3;
    private int lastHealth = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (startingHealth == lastHealth)
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
            else
            {
                startingHealth--;
            }
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
