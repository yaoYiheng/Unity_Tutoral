using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 这个类需要完成的事有:
/// 在为所挂载的游戏对象设置图片, 位置(上还是下)
/// 以及监听点击图片被点击
/// </summary>
public class WeaponIcon : MonoBehaviour 
{
    SpriteRenderer m_WeaponIcon;

    Vector3 m_CreatPosition;
    TowerInfo m_TowerInfo;
    bool m_IsEnough;

    private void Awake()
    {
        m_WeaponIcon = GetComponent<SpriteRenderer>();
    }

    //加载所需的数据
    public void LoadIcon(GameModel gameModel, TowerInfo towerInfo, Vector3 creatPosition, bool isUpside)
    {
        m_TowerInfo = towerInfo;
        m_CreatPosition = creatPosition;
        //赋值
        m_IsEnough = gameModel.Gold >= towerInfo.BasePrice;

        // 设置图标 /Res/Roles/Bottle/Bottle01
        string path =  "Res/Roles/" + (m_IsEnough ? towerInfo.NormalName : towerInfo.DisableName);
        Sprite sprite = Resources.Load<Sprite>(path);
        m_WeaponIcon.sprite = sprite;

        //根据传入的最后一个参数决定显示位置是在上还是在下
        Vector3 temp = transform.localPosition;
        temp.y = isUpside ? Mathf.Abs(temp.y) : -Mathf.Abs(temp.y);
        transform.localPosition = temp;
    }

    //当用户点击了图片后就发送创建炮塔的事件.
    // 当向外界发送事件的时候. 需要传递的参数为: 创建炮塔的ID, 以及位置
    private void OnMouseDown()
    {
        
        //如果金币不足, 则无需发送事件
        if (!m_IsEnough) return;

        //事件参数需要由上一级传入
        SpawnTowerArgs spawnTowerArgs = new SpawnTowerArgs() { TowerID = m_TowerInfo.TowerID, Position = m_CreatPosition };

        //由于该类是继承自Mono而不是框架, 所以不能使用框架的发送事件方法
        // 但该脚本所挂载的控件会作为一个继承了View对象的子控件,
        //这里选择将事件向上抛
        SendMessageUpwards("SpawnerTower", spawnTowerArgs, SendMessageOptions.DontRequireReceiver);
    }
}
