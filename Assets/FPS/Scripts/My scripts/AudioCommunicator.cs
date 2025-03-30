using UnityEngine;

public class AudioCommunicator : Communicator
{
    public override void SendMessage()
    {
        Debug.Log("AudioCommunicator: Playing a sound as a message!");
        // Here you could also play an actual AudioClip
    }
}
