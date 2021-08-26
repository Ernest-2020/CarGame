using Profile;
using UnityEngine;

public class StartFightController : BaseController
{
    private StartFightView _startFightView;
    private ProfilePlayer _profilePlayer;
    

    public StartFightController(Transform placeForUi, ProfilePlayer profilePlayer, 
        StartFightView startFightView)
    {
        _profilePlayer = profilePlayer;

        

        _startFightView = Object.Instantiate(startFightView, placeForUi);
        AddGameObjects(_startFightView.gameObject);
    }

    public void RefreshView()
    {
        _startFightView.StartFightButton.onClick.AddListener(StartFight);
        _startFightView.MenuButton.onClick.AddListener(MainMenu);
      
    }

    private void StartFight()
    {
        _profilePlayer.CurrentState.Value = GameState.Fight;
    }

    private void MainMenu()
    {
        _profilePlayer.CurrentState.Value = GameState.Start;
    }

   

    protected override void OnDispose()
    {
        _startFightView.StartFightButton.onClick.RemoveAllListeners();
        _startFightView.MenuButton.onClick.RemoveAllListeners();


        base.OnDispose();
    }
}
