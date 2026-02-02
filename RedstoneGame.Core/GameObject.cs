using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RedstoneGame.Core;

public class GameObject 
{
    public virtual void LoadContent(ContentManager content) {}
    public virtual void Start(){}
    public virtual void Tick(GameTime gameTime) {}
    public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime) {}
}