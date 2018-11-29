using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(ObjectPool))]
[RequireComponent(typeof(StaticData))]
[RequireComponent(typeof(Sound))]
public class Game : ApplicationBase<Game>
{
    void SceneManager_SceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        SceneArgs args = new SceneArgs();
        args.Level = arg0.buildIndex;


        //先要注册启动命令

        //发布进入场景的事件
        SendEvent(Const.E_EnterScene, args);
    }


    //全局访问的功能
    public ObjectPool ObjectPool = null;
    public Sound Sound = null;
    public StaticData StaticData;//静态数据


    //全局的方法
    //加载一个场景. 
    public void LoadScene(int sceneLevel)
    {

        //退出旧场景

        //创建事件参数
        SceneArgs sceneArgs = new SceneArgs();

        //获取到当前Scene的索引, 传入到事件参数的对象中
        sceneArgs.Level = SceneManager.GetActiveScene().buildIndex;

        //跳转场景的同时, 发送消息
        SendEvent(Const.E_ExitScene, sceneArgs);
         
        //调用调转场景方法 
        //加载新场景
        SceneManager.LoadScene(sceneLevel, LoadSceneMode.Single);
    }


    protected override void Awake()
    {
        base.Awake();

        SceneManager.sceneLoaded += SceneManager_SceneLoaded;
    }

    //游戏入口
    private void Start()
    {
        //确保Game对象一直都在
          DontDestroyOnLoad(this.gameObject);

        //给全局单例赋值
        ObjectPool = ObjectPool.Instance;
        Sound = Sound.Instance;
        StaticData = StaticData.Instance;

        //这个API有ApplicationBase提供, 仅在这里使用一次.  
        RegisterController(Const.E_StartUp, typeof(StartUpCommand));
        //启动游戏
        SendEvent(Const.E_StartUp);

    }


    ////加载一个新场景时候调用，参数为加载到的场景索引
    //private void OnLevelWasLoaded(int level)
    //{
    //    SceneArgs args = new SceneArgs();
    //    args.Level = level;


    //    //先要注册启动命令

    //    //发布进入场景的事件
    //    SendEvent(Const.E_EnterScene, args);
    //}

}
