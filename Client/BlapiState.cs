using Blapi.Client;

public sealed record BlapiState(double Distance, int Index)
{
    public int GetSprite() => (this.Index % 4) switch
    {
        1 => 1,
        3 => 2,
        _ => 0
    };
}