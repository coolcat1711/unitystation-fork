﻿using System;
using CameraEffects;
using Core.Utils;
using Items;
using Items.Tool;
using Mirror;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Player
{
	//how TO use
	//so, First of all you need 2 fields
	//the default state e.g when you ghost what it should be set to
	//and the active synchronised state
	//you got these two down now you build the hook
	//private void SyncXrayState(bool NotSetValueServer, bool newState)
	//so you Use SyncXrayState  to set the value, Noting that NotSetValueServer = False, every time you call it
	//and then inside of this statement
	//
	//if ((NotSetValueServer == false && isServer))
	//{
	//	SyncXRay = newState;
	//}
	//This is required so local client doesn't get Buggered by values getting reset when they Ghost
	//And then you do this check
	//if (ClientForThisBody)
	//This goes around your code that applies the value such as fov mask = x
	//this is to allow is local player = false in cases where it needs to be reset to default
	//You also must use the past in value
	// Such as NightVisionGoggles.NightVisionData newState
	// because the synchronised value is the non-reset one
	//Also use the Sync Your thing function with false and value


	/// <summary>
	/// Class which contains sync vars which are only sent to the client controlling this player
	/// </summary>
	public class PlayerOnlySyncValues : NetworkBehaviour //Deprecated and doesn't work anymore due to ownership changes
	{

	}
}
