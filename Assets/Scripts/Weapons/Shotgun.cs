﻿using UnityEngine;
using System.Collections;

public class Shotgun : Weapon
{
    void Start()
    {
        mDamage = 35;
        mCurrentReloadTime = 0f;
        mReloadTime = 10f;
        mSpread = 45f; // Spread
        mSpreadAngle = Mathf.PI / 18; // Angle in radians  (360 degrees = 2PI Radians)
        mFireRate = 10f; // Max fire rate is 60 as the game runs at 60 fps
        mChargeTime = 0f;
        mMuzzleVelocity = 30f;
        mCurrentFireTime = 0f;
        mAmmoRemaining = 10;
        mAmmoMax = 10;
    }
}