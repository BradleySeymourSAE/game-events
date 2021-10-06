# region Namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
	public class VoidListener : BaseGameEventListener<Void, VoidEvent, UnityVoidEvent> { }
}