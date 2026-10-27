using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public PlayerState playerState;
    public DistrictManager districtManager;
    public FactionManager factionManager;
    public DayNightCycle dayNightCycle;
    public WorldEventManager worldEventManager;
    public MissionManager missionManager;
    public SaveSystem saveSystem;
    public HUDController hudController;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        playerState = new PlayerState();
        districtManager = FindObjectOfType<DistrictManager>();
        factionManager = FindObjectOfType<FactionManager>();
        dayNightCycle = FindObjectOfType<DayNightCycle>();
        worldEventManager = FindObjectOfType<WorldEventManager>();
        missionManager = FindObjectOfType<MissionManager>();
        saveSystem = FindObjectOfType<SaveSystem>();
        hudController = FindObjectOfType<HUDController>();
    }

    private void Start()
    {
        if (hudController != null)
        {
            hudController.Refresh(playerState, districtManager, factionManager);
        }
    }

    private void Update()
    {
        if (hudController != null)
        {
            hudController.Refresh(playerState, districtManager, factionManager);
        }
    }

    public void SaveGame()
    {
        if (saveSystem != null)
        {
            saveSystem.Save(playerState);
        }
    }

    public void LoadGame()
    {
        if (saveSystem != null)
        {
            playerState = saveSystem.Load();
        }
    }
}
