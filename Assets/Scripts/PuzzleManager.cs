using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> _puzzleCheckers;

    private List<IPuzzleCheck> _checkers = new List<IPuzzleCheck>();

    internal event System.Action PuzzleCompleted;

    private void Awake()
    {
        foreach (var checker in _puzzleCheckers)
        {
            if (checker is IPuzzleCheck puzzleChecker)
            {
                _checkers.Add(puzzleChecker);
                puzzleChecker.Checked += OnCheckerUpdated;
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var checker in _checkers)
        {
            checker.Checked -= OnCheckerUpdated;
        }
    }

    private void OnCheckerUpdated(bool _)
    {
        foreach (var checker in _checkers)
        {
            if (!checker.IsCorrect) return;
        }

        Debug.Log("PuzzleCompleted?.Invoke();");
        PuzzleCompleted?.Invoke();
    }
}

