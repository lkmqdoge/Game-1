using Lkmqdoge.Monogame.Graphics;

using Microsoft.Xna.Framework.Graphics;

namespace RedstoneGame.Core.Entity.Player;

public class PlatformerPlayer : BasePlayer
{
    readonly Sprite2D _sprite = new();
    
    public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content) 
    {
        var texture = content.Load<Texture2D>("Textures/PlatformerPlayer");
        _sprite.Texture = texture;
    }

    public override void Tick(Microsoft.Xna.Framework.GameTime gameTime) 
    {
        
    }
}
