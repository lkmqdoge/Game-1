using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lkmqdoge.Monogame.Graphics;

public class Label2D : IDrawableItem
{
    public SpriteFont Font { get; set; }
    public string     Text { get; set; }

    public Vector2       Position    { get; set; } = Vector2.Zero;
    public Color         Color       { get; set; } = Color.White;
    public float         Rotation    { get; set; } = 0.0f;
    public Vector2       Origin      { get; set; } = Vector2.Zero;
    public float         Scale       { get; set; } = 1.0f;
    public SpriteEffects Effect      { get; set; } = SpriteEffects.None;
    public float         LayerDepth  { get; set; } = 0.0f;

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(
                Font,
                Text,
                Position,
                Color,
                Rotation,
                Origin,
                Scale,
                Effect,
                LayerDepth
                );
    }
}
