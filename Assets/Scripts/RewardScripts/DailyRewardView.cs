using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardView : MonoBehaviour
{
    private const string CurrentSlotInActiveKey = nameof(CurrentSlotInActiveKey);
    private const string TimeGetRewardKey = nameof(TimeGetRewardKey);
    
    [Header("Settings Time Get Reward")]
    [SerializeField] 
    public float _timeCooldown;
    
    [SerializeField] 
    private float _timeDeadline;

    

    [Header("Settings Rewards")]
    [SerializeField] 
    private List<Reward> _rewards;
    
    [Header("Ui Elements")]
    [SerializeField] 
    private TMP_Text _timerNewReward;
    
    [SerializeField] 
    private Transform _mountRootSlotsReward;

    [SerializeField] 
    private ContainerSlotRewardView _containerSlotRewardView;
    
    [SerializeField] 
    private Button _getRewardButton;
    
    [SerializeField] 
    private Button _resetButton;

    [SerializeField]
    private Button _closeButton;

    [SerializeField]
    public RectTransform _rectTransformRewardButton;
    [SerializeField]
    public RectTransform _rectTransformResetdButton;



    public float TimeCooldown => _timeCooldown;
    
    public float TimeDeadline => _timeDeadline;
    
    public List<Reward> Rewards => _rewards;

    public TMP_Text TimerNewReward => _timerNewReward;
    
    public Transform MountRootSlotsReward => _mountRootSlotsReward;
    
    public ContainerSlotRewardView ContainerSlotRewardView => _containerSlotRewardView;
    
    public Button GetRewardButton => _getRewardButton;
    
    public Button ResetButton => _resetButton;

    public Button CloseButton => _closeButton;

    public int CurrentSlotInActive
    {
        get => PlayerPrefs.GetInt(CurrentSlotInActiveKey, 0);
        set => PlayerPrefs.SetInt(CurrentSlotInActiveKey, value);
    }

    public DateTime? TimeGetReward
    {
        get
        {
            var data = PlayerPrefs.GetString(TimeGetRewardKey, null);
            
            if (!string.IsNullOrEmpty(data))
                return DateTime.Parse(data);

            return null;
        }
        set
        {
            if (value != null)
                PlayerPrefs.SetString(TimeGetRewardKey, value.ToString());
            else
                PlayerPrefs.DeleteKey(TimeGetRewardKey);
        }
    }

    private void OnDestroy()
    {
        _getRewardButton.onClick.RemoveAllListeners();
        _resetButton.onClick.RemoveAllListeners();
    }
}
