#region Namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GameEvents;
#endregion


namespace GameEvents
{
	[System.Serializable]
	public struct Void { }

	[CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void")]
	public class VoidEvent : BaseGameEvent<Void>
	{ 
		public void Raise() => Raise(new Void());
	}
}