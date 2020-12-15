using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAnimator : MonoBehaviour
{
    [Serializable]
    public class State
    {
        [SerializeField] bool isRepeated;
        [SerializeField, Range(0f, 0.5f)] float animationFrameRateInSeconds = 0.1f;
        [SerializeField] Sprite[] sprites;
            
        public bool IsRepeated => this.isRepeated;
        public WaitForSeconds AnimationFrameRateInSeconds => new WaitForSeconds(this.animationFrameRateInSeconds);
        public Sprite[] Sprites => this.sprites;
    }

    SpriteRenderer spriteRenderer;
    State currentState;
    
    void Start()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }
    
    public void PlayAnimation(State state)
    {
        if (state == this.currentState) return;
            
        this.StopAllCoroutines();
        this.StartCoroutine(this.AnimationRoutine(state));
    }

    public void SetFlip(bool isFlipped)
    {
        if (this.spriteRenderer.flipX != isFlipped)
        {
            this.spriteRenderer.flipX = isFlipped;
        }
    }

    IEnumerator AnimationRoutine(State animationState)
    {
        this.currentState = animationState;
        var sprites = animationState.Sprites;
        var waitForSeconds = animationState.AnimationFrameRateInSeconds;

        do
        {
            for (var i = 0; i < sprites.Length; i++)
            {
                this.spriteRenderer.sprite = sprites[i];

                yield return waitForSeconds;
            }
        } while (animationState.IsRepeated);
    }
}
