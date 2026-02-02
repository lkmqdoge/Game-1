using Microsoft.Xna.Framework;

namespace RedstoneGame.Core.Entity;

public abstract class BaseEntity : GameObject
{
    public Vector2  Position { get; set; } = Vector2.Zero;
    public Vector2  Velocity { get; set; } = Vector2.Zero;
}