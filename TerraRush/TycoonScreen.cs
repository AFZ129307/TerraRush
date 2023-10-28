using Godot;
using System;

public partial class TycoonScreen : Node2D
{
    public void SummonPressed(){
        GetTree().ChangeSceneToFile("res://summon_screen.tscn");
    }

    public void OnImageUpload(){
        GD.Print("Ligma");
    }

    public override void _Process(double delta)
    {
        GameObjectManager.Instance.Update();
        //DrawRect(new Rect2(0,0,GetViewportRect().Size), new Color(0,0,0,0), true, 1);
        foreach(IProdUnit PUnit in GameObjectManager.Instance.ActiveUnits)
        {
            PUnit.Update(delta);
            PUnit.Draw();
        }
    }
}
