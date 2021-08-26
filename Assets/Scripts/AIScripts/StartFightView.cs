 using UnityEngine;
using UnityEngine.UI;

public class StartFightView : MonoBehaviour
{
    [SerializeField]
    private Button _startFightButton;

    [SerializeField] 
    private Button _menuButton;
    
    public Button StartFightButton => _startFightButton;
    public Button MenuButton => _menuButton;
}
