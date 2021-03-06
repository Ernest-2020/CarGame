using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FightWindowView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _countMoneyText;

    [SerializeField]
    private TMP_Text _countHealthText;

    [SerializeField]
    private TMP_Text _countPowerText;

    [SerializeField]
    private TMP_Text _countPowerEnemyText;

    [SerializeField]
    private TMP_Text _countCrimeText;


    [SerializeField]
    private Button _addCoinsButton;

    [SerializeField]
    private Button _minusCoinsButton;


    [SerializeField]
    private Button _addHealthButton;

    [SerializeField]
    private Button _minusHealthButton;


    [SerializeField]
    private Button _addPowerButton;

    [SerializeField]
    private Button _minusPowerButton;

    [SerializeField]
    private Button _fightButton;

    [SerializeField]
    private Button _leaveFightButton;

    [SerializeField]
    private Button _addCrimeButton;

    [SerializeField]
    private Button _minusCrimeButton;

    public TMP_Text CountMoneyText => _countMoneyText;

    public TMP_Text CountHealthText => _countHealthText;

    public TMP_Text CountPowerText => _countPowerText;

    public TMP_Text CountCrimeText => _countCrimeText;

    public TMP_Text CountPowerEnemyText => _countPowerEnemyText;

    public Button AddCoinsButton => _addCoinsButton;

    public Button MinusCoinsButton => _minusCoinsButton;

    public Button AddHealthButton => _addHealthButton;

    public Button MinusHealthButton => _minusHealthButton;

    public Button AddPowerButton => _addPowerButton;

    public Button MinusPowerButton => _minusPowerButton;

    public Button FightButton => _fightButton;

    public Button LeaveFightButton => _leaveFightButton;

    public Button AddCrimeButton => _addCrimeButton;

    public Button MinusCrimeButton => _minusCrimeButton;
}
