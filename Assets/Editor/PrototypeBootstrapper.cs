using UnityEditor;
using UnityEngine;

public static class PrototypeBootstrapper
{
    [MenuItem("Mirror City/Create Prototype")]
    public static void CreatePrototype()
    {
        GameObject gameManagerObject = new GameObject("GameManager");
        gameManagerObject.AddComponent<GameManager>();

        GameObject playerObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        playerObject.name = "Player";
        playerObject.AddComponent<CharacterController>();
        playerObject.AddComponent<PlayerController>();
        playerObject.transform.position = new Vector3(0f, 1f, 0f);

        GameObject lightObject = new GameObject("Sun");
        Light sun = lightObject.AddComponent<Light>();
        sun.type = LightType.Directional;
        lightObject.AddComponent<DayNightCycle>();

        GameObject eventManager = new GameObject("WorldEventManager");
        eventManager.AddComponent<WorldEventManager>();

        GameObject districtManager = new GameObject("DistrictManager");
        districtManager.AddComponent<DistrictManager>();

        GameObject factionManager = new GameObject("FactionManager");
        factionManager.AddComponent<FactionManager>();

        GameObject missionManager = new GameObject("MissionManager");
        missionManager.AddComponent<MissionManager>();

        GameObject saveSystem = new GameObject("SaveSystem");
        saveSystem.AddComponent<SaveSystem>();

        GameObject canvasObject = new GameObject("HUDCanvas");
        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        canvasObject.AddComponent<CanvasScaler>();
        canvasObject.AddComponent<GraphicRaycaster>();

        GameObject panel = new GameObject("Panel");
        panel.transform.SetParent(canvasObject.transform, false);
        var image = panel.AddComponent<UnityEngine.UI.Image>();
        image.color = new Color(0f, 0f, 0f, 0.25f);

        RectTransform panelRect = panel.GetComponent<RectTransform>();
        panelRect.anchorMin = new Vector2(0f, 1f);
        panelRect.anchorMax = new Vector2(0f, 1f);
        panelRect.pivot = new Vector2(0f, 1f);
        panelRect.sizeDelta = new Vector2(320f, 120f);
        panelRect.anchoredPosition = new Vector2(20f, -20f);

        GameObject moneyTextObject = new GameObject("MoneyText");
        moneyTextObject.transform.SetParent(panel.transform, false);
        UnityEngine.UI.Text moneyText = moneyTextObject.AddComponent<UnityEngine.UI.Text>();
        moneyText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        moneyText.text = "Cash: $500";
        moneyText.fontSize = 18;
        moneyText.alignment = TextAnchor.UpperLeft;
        moneyText.color = Color.white;

        RectTransform moneyRect = moneyTextObject.GetComponent<RectTransform>();
        moneyRect.anchorMin = new Vector2(0f, 1f);
        moneyRect.anchorMax = new Vector2(1f, 1f);
        moneyRect.offsetMin = new Vector2(10f, -30f);
        moneyRect.offsetMax = new Vector2(-10f, -10f);

        GameObject heatTextObject = new GameObject("HeatText");
        heatTextObject.transform.SetParent(panel.transform, false);
        UnityEngine.UI.Text heatText = heatTextObject.AddComponent<UnityEngine.UI.Text>();
        heatText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        heatText.text = "Heat: 0";
        heatText.fontSize = 18;
        heatText.alignment = TextAnchor.UpperLeft;
        heatText.color = Color.white;

        RectTransform heatRect = heatTextObject.GetComponent<RectTransform>();
        heatRect.anchorMin = new Vector2(0f, 1f);
        heatRect.anchorMax = new Vector2(1f, 1f);
        heatRect.offsetMin = new Vector2(10f, -60f);
        heatRect.offsetMax = new Vector2(-10f, -40f);

        GameObject districtTextObject = new GameObject("DistrictText");
        districtTextObject.transform.SetParent(panel.transform, false);
        UnityEngine.UI.Text districtText = districtTextObject.AddComponent<UnityEngine.UI.Text>();
        districtText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        districtText.text = "District: District_01";
        districtText.fontSize = 18;
        districtText.alignment = TextAnchor.UpperLeft;
        districtText.color = Color.white;

        RectTransform districtRect = districtTextObject.GetComponent<RectTransform>();
        districtRect.anchorMin = new Vector2(0f, 1f);
        districtRect.anchorMax = new Vector2(1f, 1f);
        districtRect.offsetMin = new Vector2(10f, -90f);
        districtRect.offsetMax = new Vector2(-10f, -70f);

        HUDController hud = canvasObject.AddComponent<HUDController>();
        hud.moneyText = moneyText;
        hud.heatText = heatText;
        hud.districtText = districtText;
        hud.cashText = null;

        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.localScale = new Vector3(8f, 1f, 8f);

        Selection.activeGameObject = playerObject;
        Debug.Log("Mirror City prototype scene created. Use Mirror City > Create Prototype to regenerate if needed.");
    }
}
