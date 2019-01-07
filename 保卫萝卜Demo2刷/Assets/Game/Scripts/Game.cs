using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(ObjectPool))]
[RequireComponent(typeof(Sound))]
[RequireComponent(typeof(StaticData))]
public class Game : ApplicationBase<Game> 
{
    [HideInInspector]
    public ObjectPool ObjectPool = null;
    [HideInInspector]
    public Sound Sound = null;
    [HideInInspector]
    public StaticData StaticData = null;

    protected override void Awake()
    {
        base.Awake();
        SceneManager.sceneLoaded += SceneManager_SceneLoaded;
    }

    private void Start()
    {
        //且为了保证改立一直存在于整个游戏当中, 
        DontDestroyOnLoad(this.gameObject);
        //对单例进行赋值
        ObjectPool = ObjectPool.Instance;
        Sound = Sound.Instance;
        StaticData = StaticData.Instance;

        //作为游戏的入口, 需要将MVC的框架都放入到系统中. 在这里完成对第一个游戏控制器的注册
        RegisterController(Consts.E_StartUp, typeof(StartUpCommand));
        // 并向MVC发布开始的事件

        SendEvent(Consts.E_StartUp);

    }

    // 当完成了跳转后, 会调用该方法.
    // 需要在进入场景后, 发布带着进入了场景事件
    void SceneManager_SceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        //包装进入场景所需要的事件参数
        SceneIndexArgs args = new SceneIndexArgs() { SceneIndex = arg0.buildIndex };

        SendEvent(Consts.E_EnterScene, args);
    }

    //每当需要进行跳转的时候, 调用该方法进行跳转.
    public void LoadScene(int sceneIndex)
    {

        //包装事件参数
        SceneIndexArgs args = new SceneIndexArgs()
        {
            SceneIndex = SceneManager.GetActiveScene().buildIndex
        };
        // 发送离开该场景的事件
        SendEvent(Consts.E_ExitScene, args);

        //通过调用场景管理者的该方法进行场景跳转, 但是在跳转之前, 需要
        // 向系统发布准备退出当前场景的事件.
        // 只是发出该事件而已. 
        // 会有对该事件感兴趣的控制器去处理
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

}
