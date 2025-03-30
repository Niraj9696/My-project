using System.Linq;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    private Communicator[] communicators;
    private IAlert[] alerts;

    void Start()
    {
        communicators = FindObjectsOfType<Communicator>();
        alerts = FindObjectsOfType<MonoBehaviour>().OfType<IAlert>().ToArray();

        InvokeRepeating(nameof(SendMessages), 2f, 3f);
        InvokeRepeating(nameof(TriggerAlerts), 3f, 4f);
    }

    void SendMessages()
    {
        foreach (var comm in communicators)
        {
            comm.SendMessage();
        }
    }

    void TriggerAlerts()
    {
        foreach (var alert in alerts)
        {
            alert.TriggerAlert();
        }
    }
}
