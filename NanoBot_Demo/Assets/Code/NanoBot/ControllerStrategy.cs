﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllerStrategy
{
    //Constructor
    public ControllerStrategy()
    {

    }

    //Abstract Functions
    public abstract void TopDown_Update(NanoBotController pNB);
    public abstract void SideView_Update(NanoBotController pNB);
	
}
