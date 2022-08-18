using DependencyManagement;
using Systems;
using UnityEngine;

public class StartController : MonoBehaviour
{
    private IContext _globalContext;

    private SystemManager _systemManager;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        
    }

    void Start()
    {
        _globalContext = new GlobalContext();
    }

    void Update()
    {
        _systemManager.Update(Time.deltaTime);
    }
}
