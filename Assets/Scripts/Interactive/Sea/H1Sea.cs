using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DialogueController))]
public class H1Sea : Sea
{
    private DialogueController dialogueController;

    private void Awake()
    {
        dialogueController = GetComponent<DialogueController>();
    }
    protected override void EnterWater()
    {
        // 角色自言自语
        int num = Random.Range(0, 2);
        if(num == 0)
            dialogueController.ShowdialogueEmpty();
        else
            dialogueController.ShowdialogueFinish();

        // 一段时间后对话框消失（暂时使用Invoke）
        Invoke("CleanDialogue", 2f);
    }
    private void CleanDialogue()
    {
        EventHandler.CallShowDialogueEvent(string.Empty);
    }
}
