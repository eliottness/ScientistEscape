using System;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using System.Collections;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player is spawned after dying.
    /// </summary>
    public class WaterBottleRespawn : Simulation.Event<WaterBottleRespawn>
    {
        public override void Execute()
        {
            var grid = GameObject.Find("Grid");
            for (int i = 0; i < grid.transform.childCount; i++)
            {
                var child = grid.transform.GetChild(i);
                if (child.transform.name.Contains("WaterBottle"))
                {
                    child.GetComponent<DragRigidBody2D>().Reset();
                    child.gameObject.SetActive(true);
                }
        }
            
        }
    }
}

