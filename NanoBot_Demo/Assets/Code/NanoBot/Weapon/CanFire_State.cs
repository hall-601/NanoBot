﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanFire_State : FireState
{
    public CanFire_State()
        :base()
    {

    }

    public override void Fire_Projectile(Weapon_Projectile WP)
    {
        WP.CreateProjectile();
    }
}
