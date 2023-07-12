
using Photon.Pun;
using UnityEngine;

using Uduino;
using Whisper;
using UnityEngine.Events;
using System.Collections.Generic;
using static UnityEngine.Rendering.DebugUI;
using System;

public class player : MonoBehaviour
{
    Vector3 headRotation;
    float rotationStep=.1f;
    float sensorValue;
    PhotonView pv;
    PhotonView AIpv;
    PhotonView MyPV;
    int ActorNm;
    SignalProcessor processor;

    // Start is called before the first frame update
    private void Awake()
    {
       UduinoManager.Instance.OnDataReceived += readSensor; //Create the Delegate
      
    }
    void Start()
    {
        MyPV = GetComponent<PhotonView>();
        ActorNm = MyPV.OwnerActorNr;
        processor = new SignalProcessor(20, true);
        pv = GameObject.Find("Bone").GetComponent<PhotonView>();

        singleton._singletonEvent.AddListener(sendText);
        // Add invoke for resetting auto range
    }
    bool send;
    string _text;
    // Add auto reset function
    private void Update()
    {
        UduinoDevice board = UduinoManager.Instance.GetBoard("Arduino");
        UduinoManager.Instance.Read(board, "readSensors"); // Read every frame the value of the "readSensors" function on our board.
        headRotation = HeadRotation();

   
    }

    Vector3 HeadRotation()
    {
        var head = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.Head, head);
        Quaternion rotation = new Quaternion();
        if (head.Count > 0)
        {
            head[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion headRotation);
            rotation = headRotation;
        }
        return (rotation.eulerAngles);
    }
    void readSensor(string data, UduinoDevice device)
    {

        float inputValue;
        bool success = float.TryParse(data, out inputValue );
        if (success)
        {
            Console.WriteLine($"Converted '{data}' to {inputValue}.");
        }
        else
        {
            Console.WriteLine($"Attempted conversion of '{data ?? "<null>"}' failed.");
        }

        processor.AddValue(inputValue);
        sensorValue = processor.GetNormalized();
        processor.extremum();
   

        if (MyPV.IsMine)
        {
            sendData();
        }
    }
    // Update is called once per frame
    /*   private void Update()
       {
           if (Input.GetKeyDown("s"))
           {
               rotation -= .1f;
               Debug.Log("rotation");

           }
           if (Input.GetKeyDown("w"))
           {
               rotation += .1f;

           }
           if (MyPV.IsMine)
           {
               sendData();

           }
       }
   */
    public void sendText(string text)
    {
        AIpv = GameObject.Find("combineTexts").GetComponent<PhotonView>();
        AIpv.RPC("ReceiveString", RpcTarget.All, text, ActorNm);

    
    }
    void sendData()
    {
        if (pv)
        {
            pv.RPC("ReceiveFloat", RpcTarget.All, sensorValue,processor.MaxReached(),headRotation, ActorNm);

        }
        else
        {
            Debug.Log("photon view object was not found hahaha");
        }
    }
}
