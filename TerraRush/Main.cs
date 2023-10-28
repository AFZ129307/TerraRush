using Godot;
using System;

public partial class Main : Node2D
{
    public void OnPlayPressed(){
        GetTree().ChangeSceneToFile("res://tycoon_screen.tscn");
        GameObjectManager.Instance.ReqActivate(new Cleaner());
    }

    public void OnQuitPressed(){
        GetTree().Quit();
    }

}
