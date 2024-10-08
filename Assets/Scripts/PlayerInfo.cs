using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{
    private static int money;

    public static int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }
}
