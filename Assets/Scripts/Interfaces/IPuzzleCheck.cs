using UnityEngine;

interface IPuzzleCheck
{
    bool IsCorrect { get; }
    event System.Action<bool> Checked;
}
