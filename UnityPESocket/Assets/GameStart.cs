/****************************************************
    文件：GameStart.cs
	作者：Yiheng
    邮箱: fn1117@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Protocal;
using PENet;
public class GameStart : MonoBehaviour 
{

    public PESocket<ClientSession, NetMessage> client;
    
    private void Start()
    {
        //在客户端新建一个Socket
        client = new PESocket<ClientSession, NetMessage>();
        //配置Ip和端口
        client.StartAsClient(IPConfigure.srvIP, IPConfigure.srePort);
        //设置打印日志的接口
        client.SetLog(true, (string message, int level) =>
        {
            message = "Log:" + message;
            switch (level)
            {
                case 0:

                    Debug.Log(message);
                    break;

                case 1:

                    Debug.LogWarning(message);
                    break;

                case 2:
                    Debug.LogError(message);
                    break;

                case 3:
                    Debug.Log(message);
                    break;
                default:
                    break;
            }
        });

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            client.session.SendMsg(new NetMessage() { text = "Hello Unity" });
        }
    }
}