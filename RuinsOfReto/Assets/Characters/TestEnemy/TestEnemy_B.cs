﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace masterFeature
{
    public class TestEnemy_B : Controller
    {

        // Start is called before the first frame update
        private void Start()
        {
            start();

            health = 2;
            deathTimeLength = 1.0f;
            canRespawn = false;
        }

        
    }
}