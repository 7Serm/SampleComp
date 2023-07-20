using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdata 
{
    public string ID;
    public Player Player;
    public string[] Friends;

}
[Serializable]
public class Player
{
    public string name;
    public int score;
}
