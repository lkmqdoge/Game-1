using Lkmqdoge.Monogame;
using Lkmqdoge.Monogame.Graphics;
using Lkmqdoge.Monogame.Input;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using RedstoneGame.Core.Entity.Projectile;

namespace RedstoneGame.Core;

public class Game1 : GameCore
{
    private readonly Label2D _label = new();
    private SpriteFont _font;

    public Game1()
    {
        InputManager.AddAction(
            new InputAction("debug_exit", [ Keys.Escape ])
        );
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _font = Content.Load<SpriteFont>("Fonts/debug");
        _label.Font = _font;
        _label.Text = "Hello world";
    }

    protected override void Update(GameTime gameTime)
    {
        InputManager.Update();

        if (InputManager.IsActionJustPressed("debug_exit"))
            Exit();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        SpriteBatch.Begin();
        _label.Draw(SpriteBatch);
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}