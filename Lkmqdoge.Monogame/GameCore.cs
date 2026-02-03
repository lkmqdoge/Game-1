using Lkmqdoge.Monogame.Input;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Lkmqdoge.Monogame;

public class GameCore : Game
{
    public InputManager          InputManager { get; private set; }
    public GraphicsDeviceManager Graphics     { get; private set; }
    public SpriteBatch           SpriteBatch  { get; private set; }

    public Color BackgroundColor { get; set; }
        = Color.MonoGameOrange;

    public GameCore()
    {
        InputManager = new();
        Graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void LoadContent() 
    {
        base.LoadContent();
        SpriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        InputManager.Update();
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(BackgroundColor);

        base.Draw(gameTime);
    }
}