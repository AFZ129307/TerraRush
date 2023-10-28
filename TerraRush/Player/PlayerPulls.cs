using Godot;
using System;

public partial class PlayerPulls : Label
{
    public override void _Ready(){
        Update();
    }

    public override void _Process(double delta)
    {
        Update();
    }

    public void Update(){
        Text = "Pulls: " + PlayerInfo.Instance.Pulls;
    }
}
