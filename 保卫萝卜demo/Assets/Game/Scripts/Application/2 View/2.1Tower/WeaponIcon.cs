using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIcon : MonoBehaviour 
{

	SpriteRenderer m_Renderer;
	bool m_IsEnough;
	WeaponInfo m_WeaponInfo;
	Vector3 m_CreatPosition;
	private void Awake()
	{
		m_Renderer = GetComponent<SpriteRenderer>();
	}

	/// 需要数据 位置 塔信息 在上还是在下显示
	public void Load(GameModel game, Vector3 position, WeaponInfo info, bool UpSide)
	{
		m_WeaponInfo = info;
		m_CreatPosition = position;
		//根据传入的金币来判断是否足够
		m_IsEnough = game.Score >= info.BasePrice;
		m_IsEnough = true;
		//根据是否足够设置对应的图片"file://" + Const.CardPath + cardInfo.CardName;
		string path =  "Res/Roles/"  + (m_IsEnough? info.NormalIcon: info.DisableIcon);
		// string path =  "Res/Maps/bg1";
		print(path);
		//根据路径获得图片
		Sprite temps = Resources.Load<Sprite>(path);
		m_Renderer.sprite = temps;


		//根据在上还是在下设置图片的位置
		Vector3 temp = this.transform.localPosition;
		temp.y = (UpSide? Mathf.Abs(temp.y): -Mathf.Abs(temp.y));
		this.transform.localPosition = temp;
	}
		

	void OnMouseDown()
	{
		//给创建一个武器的参数赋值
		SpawnWeaponArgs args = new SpawnWeaponArgs(){Position = m_CreatPosition, TowerID = m_WeaponInfo.WeaponID};
		SendMessageUpwards(Const.F_SpawnWeapon, args, SendMessageOptions.RequireReceiver);
	}
}
