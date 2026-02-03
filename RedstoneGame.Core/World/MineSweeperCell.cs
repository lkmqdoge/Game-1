namespace RedstoneGame.Core.World;

public struct MineSweeperCell
{
    public bool Revealed  { get; set; }
    public bool Flagged   { get; set; }
    public bool HasMine   { get; set; }

    public int MinesAround { get; set; } 
}
