using Godot;
using System;

public partial class SummonScreen : Node2D
{
    public void OnePullPressed(){
        if(PlayerInfo.Instance.Pulls < 1){
            // To-Do
        }
        PlayerInfo.Instance.UpdatePulls(-1);
    }

    public void TenPullPressed(){
        if(PlayerInfo.Instance.Pulls<10){
            // To-Do
        }
        PlayerInfo.Instance.UpdatePulls(-10);
    }
}
