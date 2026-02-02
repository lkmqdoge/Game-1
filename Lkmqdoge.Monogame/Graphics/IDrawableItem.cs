using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lkmqdoge.Monogame.Graphics;

public interface IDrawableItem
{
    Vector2       Position    { get; }
    Color         Color       { get; }
    float         Rotation    { get; }
    Vector2       Origin      { get; }
    float         Scale       { get; }
    SpriteEffects Effect      { get; }
    float         LayerDepth  { get; }

    void Draw(SpriteBatch spriteBatch);
}
