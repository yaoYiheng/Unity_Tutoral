using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : View
{



    public override string Name
    {
        get
        {
            return Consts.V_Menu;
        }
    }

    public override void AddEventToList()
    {
        AttentionEventList.Add(Consts.E_MenuShow);
    }

    public override void HandleEvent(string eventName, object data = null)
    {
        switch (eventName)
        {
            case Consts.E_MenuShow:
                Show();

                break;
            default:
                break;
        }
    }

    public void OnContinueClick()
    {
        Hide();
        Time.timeScale = 1;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }



    public void OnRestartClick()
    {
        GameModel game = GetModel<GameModel>();
        // SendEvent(Const.E_StartLevel, new StartLevelArgs(){LevelIndex = game.PlayingLevelIndex});
        StarLevelArgs e = new StarLevelArgs();
        game.IsPlaying = false;
        e.LevelCardIndex = game.CurrentPlayingIndex;

        SendEvent(Consts.E_RestartRound);
        SendEvent(Consts.E_StartLevel, e);
    }


    public void OnSelectClick()
    {
        GameModel game = GetModel<GameModel>();
        game.IsPlaying = false;
        SendEvent(Consts.E_RestartRound);
        Game.Instance.LoadScene(2);
    }

}
