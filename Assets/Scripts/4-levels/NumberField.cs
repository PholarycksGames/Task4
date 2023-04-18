using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour {
    private int number;
    private TextMeshPro livesText;
    [SerializeField] DestroyOnTrigger2D destroyOnTrigger2DScript;

    private void Start()
    {
        livesText = GetComponent<TextMeshPro>();
        livesText.text = destroyOnTrigger2DScript.health.ToString();
    }

    private void Update()
    {
        livesText.text = destroyOnTrigger2DScript.health.ToString();
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        GetComponent<TextMeshPro>().text = newNumber.ToString();
    }

    public void AddNumber(int toAdd) {
        SetNumber(this.number + toAdd);
    }
}
