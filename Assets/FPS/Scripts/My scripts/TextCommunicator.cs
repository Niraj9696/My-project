using UnityEngine;

public class TextCommunicator : Communicator
{
    public override void SendMessage()
    {
        Debug.Log("TextCommunicator: Sending a text message!");
    }
}
