using Systems;
using UnityEngine;

public class StartController : MonoBehaviour
{
    private SystemManager _systemManager;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        _systemManager = new SystemManager();
    }

    void Start()
    {
        
    }

    void Update()
    {
        _systemManager.Update(Time.deltaTime);
    }
}
