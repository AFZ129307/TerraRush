using Godot;

public interface IProdUnit
{
    public Sprite2D Sprite {get; set;}
    public CollisionObject2D CollisionObj {get; set;}
    public void Draw();
    public void Update(double delta);
}