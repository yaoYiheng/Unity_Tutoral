/****************************************************
    文件：ClientSession.cs
	作者：Yiheng
    邮箱: fn1117@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PENet;
using Protocal;
public class ClientSession : PENet.PESession<NetMessage>
{
    protected override void OnConnected()
    {
        Debug.Log("Server Connet");
    }

    protected override void OnDisConnected()
    {
        Debug.Log("Client DisConnet");
    }

    protected override void OnReciveMsg(NetMessage msg)
    {
         Debug.Log("Server Rsp:" + msg.text);
    }
}