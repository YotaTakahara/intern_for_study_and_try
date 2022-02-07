using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using FancyScrollView.Takahara;
using UnityEngine;
using UnityEngine.UI;
using FancyScrollView.Takahara;
using FancyScrollView.Example03;

public class ChatSystem : MonoBehaviour
{
    private int id = 0;
    [SerializeField] private InputField chatInputField;
    [SerializeField] private GameObject chatNodePrefab;
    [SerializeField] private GameObject content;

    [SerializeField] private Example03 example03;

  
    
    
   // [SerializeField] private CountNode countNode;


   private void Start()
   {
       
   }


   public void OnClickMineButton()
    {
        CreateChatNode(ChatRoll.MINE);
    }

    public void OnClickOthersButton()
    {
        CreateChatNode(ChatRoll.OTHERS);
    }


    void CreateChatNode(ChatRoll roll)
    {
        id++;
        string str = chatInputField.text;
        chatInputField.text = "";

        ChatData data = new ChatData(id, roll, str);

        var chatNode = (GameObject) Instantiate<GameObject>(chatNodePrefab, content.transform, false);
       // countNode.PlusIndex();
        chatNode.GetComponent<ChatNode>().Init(data);
        
        example03.NodeCountAdd();
        // Debug.Log(("id:" + id + " roll:" + roll.ToString() + " body:" + str));
    }
}

public enum ChatRoll
{
    MINE,
    OTHERS
}

public class ChatData
{
    private int id;
    public ChatRoll roll;
    public string body;

    public ChatData(int id, ChatRoll roll, string body)
    {
        this.id = id;
        this.roll = roll;
        this.body = body;
    }
}