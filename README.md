# Unity 2D Sprite animator

![Sprite animator example](https://media.giphy.com/media/BNmw3wb2YlJxBsc4m3/giphy.gif)

## Key features

- Animation based on state.
- Adjust animation speed.
- Change sprite flip.
- Repeated/Non-repeated animations.

## Usage

1. Create a player `GameObject`.
2. Create a player script and attach it to the newly created object.
3. Add some serialized `SpriteAnimator.State` fields to the player object.
4. Add the animation sprites into the newly created `SpriteAnimator.State` fields.
5. Adjust animation speed and other values to your liking.
6. Attach a `SpriteAnimator` component to the player object.
7. In the player script, call `PlayAnimation` on `SpriteAnimator` and pass in the serialized `SpriteAnimator.State`.

### Notes

- To flip the animation horizontally, call `SetFlip` on the `SpriteAnimator`.
- See the Sprite Animator Example in this repo to see it in action and play around with it.
