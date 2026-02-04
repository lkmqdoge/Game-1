using System.Collections.Generic;

using Lkmqdoge.Monogame;
using Lkmqdoge.Monogame.Graphics;
using Lkmqdoge.Monogame.Input;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using RedstoneGame.Core.World;

namespace RedstoneGame.Core;

public class Game1 : GameCore
{
    private readonly Label2D _label = new();

    private SpriteFont _font;

    private readonly List<GameObject> _gameObjects = [];

    public Game1() : base()
    {
        InputManager.AddAction(
            new InputAction("debug_exit", [ Keys.Escape ])
        );
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        // главная сцена
        AddGameObject(new MineSweeperField(0, 0, 10, 10));
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();
        _font = Content.Load<SpriteFont>("Fonts/debug");
        _label.Font = _font;
        _label.Text = "Hello world";

        foreach(var obj in _gameObjects)
            obj.LoadContent(Content);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime); // update input 

        if (InputManager.IsActionJustPressed("debug_exit"))
            Exit();

        foreach(var obj in _gameObjects)
            obj.Tick(gameTime); // FIX
    }

    protected override void Draw(GameTime gameTime)
    {
        base.Draw(gameTime);

        SpriteBatch.Begin();
        _label.Draw(SpriteBatch);
        foreach(var obj in _gameObjects)
            obj.Draw(SpriteBatch, gameTime);
        SpriteBatch.End();
    }

    public void AddGameObject(GameObject gameObject)
    {
        _gameObjects.Add(gameObject);
        gameObject.Start();
    }
}