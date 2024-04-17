// Model
public class GameData
{
    public int Score { get; set; }
    public int Lives { get; set; }
}

// View
public class GameView : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;

    public void UpdateView(GameData data)
    {
        scoreText.text = "Skor: " + data.Score;
        livesText.text = "Can: " + data.Lives;
    }
}

// Controller
public class GameController : MonoBehaviour
{
    private GameData gameData = new GameData();
    private GameView view;

    void

// yusufortacdeveloper