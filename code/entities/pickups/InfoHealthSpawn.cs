﻿using Sandbox;

namespace Fortwars
{
	[Library( "info_health_spawn" )]
	[Hammer.EntityTool( "Health Spawn", "FortWars" )]
	[Hammer.EditorModel( "models/sbox_props/burger_box/burger_box.vmdl" )]
	public class InfoHealthSpawn : ModelEntity
	{
		HealthPickup pickup;

		public override void Spawn()
		{
			base.Spawn();

			pickup = new();
			pickup.Position = Position;
		}
	}
}
