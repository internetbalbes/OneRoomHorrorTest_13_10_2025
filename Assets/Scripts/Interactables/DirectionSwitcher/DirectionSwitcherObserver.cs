using UnityEngine;

public class DirectionSwitcherObserver : MonoBehaviour, IPuzzleCheck
{
    [SerializeField] private DirectionSwitcher[] _switchers;
    [SerializeField] private DirectionSwitcher.Directions[] _correctDirections;

    public event System.Action<bool> Checked;

    public bool IsCorrect { get; private set; }

    private void OnEnable()
    {
        for (int i = 0; i < _switchers.Length; i++)
        {
            _switchers[i].Switched += CheckSwitchers;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _switchers.Length; i++)
        {
            _switchers[i].Switched -= CheckSwitchers;
        }
    }

    private void CheckSwitchers()
    {
        bool allCorrect = true;
        for (int i = 0; i < _switchers.Length; i++)
        {
            if (_switchers[i].Direction != _correctDirections[i])
            {
                allCorrect = false;
                break;
            }
        }

        IsCorrect = allCorrect;
        Checked?.Invoke(allCorrect);
    }
}
