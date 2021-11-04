using UnityEngine;
using UnityEngine.UI;

public class HighlightController : MonoBehaviour
{
    public Text UIText;
    public string MenuText;
    public SpriteRenderer Highlight;

#if UNITY_EDITOR
    private void OnValidate()
    {
        Highlight = GetComponent<SpriteRenderer>();
        Highlight.enabled = false;

        var boxCollider = GetComponent<BoxCollider2D>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider2D>();
        }
    }
#endif

    private void OnMouseEnter()
    {
        UIText.text = MenuText;
        SwitchVisibility(true);
    }

    private void OnMouseExit()
    {
        SwitchVisibility(false);
    }

    private void SwitchVisibility(bool state)
    {
        Highlight.enabled = state;
        UIText.enabled = state;
    }
}
