using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;

namespace Platformer.Mechanics
{
    /// <summary>
    /// DeathZone components mark a collider which will schedule a
    /// PlayerEnteredDeathZone event when the player enters the trigger.
    /// </summary>
    public class DeathZone : MonoBehaviour
    {
		readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        void OnTriggerEnter2D(Collider2D collider)
        {
           	if (collider == model.player.collider2d)
			{
                var ev = Schedule<HealthIsZero>();
                ev.health = model.player.health;
			} 
        }
    }
}