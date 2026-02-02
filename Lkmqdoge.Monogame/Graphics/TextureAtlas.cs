using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;

namespace Lkmqdoge.Monogame.Graphics;

public class TextureAtlas
{
    public Texture2D Texture { get; set; }

    private readonly Dictionary<string, TextureRegion> _regions = [];

    public TextureAtlas() {}

    public TextureAtlas(Texture2D texture)
    {
        Texture = texture;
    }

    public void AddRegion(string name, int x, int y, int w, int h)
    {
        var region = new TextureRegion(Texture, x, y, w, h);
        _regions.Add(name, region);
    }

    public TextureRegion GetRegion(string name)
        => _regions[name];

    public bool RemoveRegion(string name)
        => _regions.Remove(name);

    public void Clear()
        => _regions.Clear();
}
