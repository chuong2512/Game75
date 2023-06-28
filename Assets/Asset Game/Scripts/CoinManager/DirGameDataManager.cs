using JumpFrog;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class DirGameDataManager : PersistentSingleton<DirGameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [HideInInspector] public PlayerData playerData;
    
    private void Start()
    {
        Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
    }

    

    public void ResetData()
    {
        playerData.ResetData();
    }
    
    private void OnEnable()
    {
        playerData = new GameObject(Constant.DataKey_PlayerData).AddComponent<PlayerData>();
        playerData.transform.parent = transform;
        playerData.Init();
    }
}