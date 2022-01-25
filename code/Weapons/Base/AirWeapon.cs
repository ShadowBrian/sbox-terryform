﻿using Sandbox;
using Grubs.Pawn;

namespace Grubs.Weapons
{
	public abstract partial class AirWeapon : Weapon
	{
		// Weapon settings
		public override string WeaponName => "";
		public override string ModelPath => "";
		public override bool IsFiredTurnEnding => true;
		public override HoldPose HoldPose => HoldPose.Holdable;

		/// <summary>
		/// What happens when you actually fire the weapon.
		/// </summary>
		protected override void Fire()
		{
			ShowWeapon( Parent as Worm, false );
		}

		[ClientRpc]
		public override void OnFireEffects()
		{
			// Do something?
		}
	}
}