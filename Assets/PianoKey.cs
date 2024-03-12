using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKey : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite pressedSprite;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Thiết lập sprite mặc định khi khởi tạo
        spriteRenderer.sprite = normalSprite;
    }
    private void OnMouseDown()
    {
        // Khi phím được nhấn, chuyển sang sprite khi được nhấn
        if (spriteRenderer != null && pressedSprite != null)
        {
            spriteRenderer.sprite = pressedSprite;
        }
    }

    private void OnMouseUp()
    {
        // Khi phím được nhả, chuyển về sprite bình thường
        if (spriteRenderer != null && normalSprite != null)
        {
            spriteRenderer.sprite = normalSprite;
        }
        // Update is called once per frame

    }
}

