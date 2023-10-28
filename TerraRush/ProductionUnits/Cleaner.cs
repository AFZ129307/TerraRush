using System;
using Godot;

public class Cleaner : IProdUnit
{
    public Sprite2D Sprite{get; set;}
    public CollisionObject2D CollisionObj{get; set;}

    public Cleaner()
    {
        // Initialize sprites
        Sprite = new Sprite2D();
        Sprite.Texture = (Texture2D) GD.Load("res://MadKauLogo.png");
        Sprite.Position = new Vector2(200,200);
    }

    public void Draw()
    {
        Sprite._Draw();
    }
    public void Update(double delta)
    {
        PlayerInfo.Instance.UpdateScore(1);
    }
}
