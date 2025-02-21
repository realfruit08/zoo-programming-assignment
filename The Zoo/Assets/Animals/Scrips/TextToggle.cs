using UnityEngine;

public class TextToggle : MonoBehaviour
{
    [SerializeField]
    GameObject sprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sprite.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sprite.SetActive(false);
    }
}
