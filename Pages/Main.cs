using Godot;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public partial class Main : Panel
{
    private FileDialog fileDialog;
    private ConfirmationDialog confirmationDialog;

    public override void _Ready()
    {
        fileDialog = GetNode("FileDialog") as FileDialog;
        confirmationDialog = GetNode("ConfirmationDialog") as ConfirmationDialog;
    }

    private void ConfirmationDialog_click()
    {
        confirmationDialog.PopupCenteredClamped();
    }

    private void FileDialog_click()
    {
        fileDialog.PopupCenteredClamped();
    }
}
