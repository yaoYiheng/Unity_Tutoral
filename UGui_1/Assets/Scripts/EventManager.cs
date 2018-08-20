using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class EventManager
{
    public static void addEventListner(GameObject gameObject, EventTriggerType triggerType, UnityAction<BaseEventData> unityAction)
    {
        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>();

        if(eventTrigger == null)
        {
            eventTrigger = gameObject.AddComponent<EventTrigger>();
        }
        List<EventTrigger.Entry> entries = eventTrigger.triggers;

        if(entries == null)
        {
            entries = new List<EventTrigger.Entry>();
            eventTrigger.triggers = entries;
        }

        EventTrigger.TriggerEvent trigger = new EventTrigger.TriggerEvent();
        trigger.AddListener(unityAction);
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = triggerType;
        entry.callback = trigger;

        entries.Add(entry);

    }

}
