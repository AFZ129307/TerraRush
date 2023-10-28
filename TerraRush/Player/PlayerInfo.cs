using System;
using Godot;

public class PlayerInfo{

    private static PlayerInfo instance = new PlayerInfo();

    public static PlayerInfo Instance
    {
        get
        {
            return instance;
        }
    }

    public int Credits {get; private set;}
    public int Pulls{get; private set;}
    public ulong Score{get; private set;}

    private PlayerInfo(){
        Credits = 0;
        Pulls = 0;
        Score = 0;
    }

    public void UpdateCredits(int Credits){
        this.Credits += Credits;
    }

    public void UpdatePulls(int Pulls){
        this.Pulls += Pulls;
    }

    public void UpdateScore(ulong ScoreToAdd){
        Score += ScoreToAdd;
    }

}