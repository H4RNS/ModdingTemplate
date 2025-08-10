using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace ModdingTemplate
{
	[BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
	public class Plugin : BaseUnityPlugin
	{
        void Start() => GorillaTagger.OnPlayerSpawned(Initialization);

		void Initialization()
		{
  
		}
	}
}

