using Godot;
using System;

public partial class ClearScreen : Control
{
    public override void _Draw()
    {
        DrawRect(new Rect2(0,0,GetViewportRect().Size), new Color(0,0,0,0), true);
    }
}
