#region Namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents;
#endregion


namespace GameEvents
{
        public abstract class BaseGameEvent<T> : ScriptableObject
    {

        private readonly List<IEventListener<T>> m_EventListeners = new List<IEventListener<T>>();

        public void RegisterListener(IEventListener<T> p_EventListener)
        {
            m_EventListeners.Add(p_EventListener);
        }

        public void UnregisterListener(IEventListener<T> p_EventListener)
        {
            m_EventListeners.Remove(p_EventListener);
        }

        public void Raise(T p_TypeParameter)
        {
            for (int i = m_EventListeners.Count - 1; i >= 0; --i)
            {
                m_EventListeners[i].RaiseEvent(p_TypeParameter);
            }
        }
    }
}