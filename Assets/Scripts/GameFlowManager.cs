using UnityEngine;

public enum GameState{Play, Won, Lost}

public class GameFlowManager : MonoBehaviour
{
    public float endSceneLoadDelay = 3f;

    public CanvasGroup endGameFadeCanvasGroup;

    public string winSceneName = "WinScene";

    public string loseSceneName = "LoseScene";

    public float delayBeforeFadeToBlack = 4f;

    public float delayBeforeWinMessage = 2f;

    public AudioClip victorySound;

    public GameState gameState { get; private set; }
}
