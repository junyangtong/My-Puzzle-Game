using System;
using UnityEngine;

public static class EventHandler
{
    public static event Action<ItemDetails,bool>ItemSelectedEvent;
    public static void CallItemSelectedEvent(ItemDetails itemDetails,bool isSelected)
    {
        ItemSelectedEvent?.Invoke(itemDetails,isSelected);
    }

    public static event Action<ItemName> ItemUsedEvent;
    public static void CallItemUsedEvent(ItemName itemName)
    {
        ItemUsedEvent?.Invoke(itemName);
    }

    //对话
    public static event Action<string> ShowDialogueEvent;
    public static void CallShowDialogueEvent(string dialogue)
    {
        ShowDialogueEvent?.Invoke(dialogue);
    }

    //游戏状态
    public static event Action<GameState> GameStateChangeEvent;
    public static void CallGameStateChangeEvent(GameState gameState)
    {
        GameStateChangeEvent?.Invoke(gameState);
    }

    //提示标签
    public static event Action<ItemName,bool> UpdateItemNameEvent;
    public static void CallUpdateItemNameEvent(ItemName itemName,bool isSelected)
    {
        UpdateItemNameEvent?.Invoke(itemName,isSelected);
    }

    //检查密码是否匹配
    public static event Action CheckGameStateEvent;
    public static void CallCheckGameStateEvent()
    {
        CheckGameStateEvent?.Invoke();
    }
}