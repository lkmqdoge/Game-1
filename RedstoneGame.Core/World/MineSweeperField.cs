using Lkmqdoge.Monogame.Graphics;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RedstoneGame.Core.World;

public class MineSweeperField : GameObject
{
    public MineSweeperCell[,] Cells { get; set; }

    public Vector2 Position { get; set; }

    private readonly Sprite2D _testSprite = new (); 

    public MineSweeperField(int x, int y, int w, int h)
    {
        _testSprite.Position = new (x, y);
        _testSprite.Scale = 5.0f;
    }

    public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content) 
    {
        _testSprite.Texture = content.Load<Texture2D>("Textures/minesweeper");
    }

    public override void  Draw(SpriteBatch spriteBatch, GameTime gameTime)
    {
        _testSprite.Draw(spriteBatch);
    }
}
