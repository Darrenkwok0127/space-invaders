using UnityEditor.U2D;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Tilemaps;

public class invader : MonoBehaviour
{
    public Sprite[] animationSprites;  
    public float animationTime = 1.0f;

    private SpriteRenderer spriteRenderer;
    public int _animationFrame;
    private void Awake() 
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();

        InvokeRepeating(nameof(Animate), 0f, animationTime);
    }
    
    private void Animate()
    {
        int n = animationSprites.Length;
        
        _animationFrame = _animationFrame + 1;
        if (_animationFrame >= this.animationSprites.Length)
        {
            _animationFrame = 0;
        }

        //Set Sprite
        spriteRenderer.sprite = this.animationSprites[_animationFrame];
    }
}

    