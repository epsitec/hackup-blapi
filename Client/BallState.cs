using Blapi.Client;

public sealed record BallState(double X, double Y, double Direction, double Speed)
{
    public double Angle => this.Direction * Math.PI / 180;
    public double Radius => 40.0;
}
