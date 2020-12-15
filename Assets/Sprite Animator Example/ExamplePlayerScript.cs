using UnityEngine;

namespace Sprite_Animator_Example
{
    [RequireComponent(typeof(SpriteAnimator))]
    public class ExamplePlayerScript : MonoBehaviour
    {
        [SerializeField] SpriteAnimator.State idleAnimation;
        [SerializeField] SpriteAnimator.State moveAnimation;

        SpriteAnimator spriteAnimator;

        void Start()
        {
            this.spriteAnimator = this.GetComponent<SpriteAnimator>();
        }
        
        void Update()
        {
            var horizontalInput = Input.GetAxisRaw("Horizontal");

            if (horizontalInput > 0f)
            {
                this.spriteAnimator.PlayAnimation(this.moveAnimation);
                this.spriteAnimator.SetFlip(false);
            }
            else if (horizontalInput < 0f)
            {
                this.spriteAnimator.PlayAnimation(this.moveAnimation);
                this.spriteAnimator.SetFlip(true);
            }
            else
            {
                this.spriteAnimator.PlayAnimation(this.idleAnimation);
            }
        }
    }
}
