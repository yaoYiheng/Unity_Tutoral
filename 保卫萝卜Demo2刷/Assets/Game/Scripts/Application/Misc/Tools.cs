using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using System.Xml;
using UnityEngine.UI;

public static class Tools
{
	// 从资源目录中加载所有的XML文件到内存.
	// 读取关卡列表
	public static List<FileInfo> GetLevelFiels()
	{
		//读取给定文件路径下, 指定文件后缀名的所有文件, 以字符串数组形式返回
		string[] files = Directory.GetFiles(Consts.LevelPath, "*.xml");

		//遍历上数组. 将数组中的各个元素转换成文件
		//创建文件列表
		List<FileInfo> fileLists = new List<FileInfo>();
		foreach (string item in files)
		{
			FileInfo file = new FileInfo(item);
			fileLists.Add(file);
		}

		return fileLists;

	}


	// 将读取到内存中的xml文件写入到Level类中. 
	public static void FillLevel(string fileName, ref Level level)
	{
		FileInfo xmlFile = new FileInfo(fileName);

		//根据file得到数据流
		StreamReader stream = new StreamReader(xmlFile.OpenRead(), Encoding.UTF8);

		XmlDocument xmlDocument = new XmlDocument();

		xmlDocument.Load(stream);
		//为Level类对象的各个属性赋值
 
		level.Name = xmlDocument.SelectSingleNode("Level/Name").InnerText;
		level.CardImage = xmlDocument.SelectSingleNode("Level/CardImage").InnerText;
		level.Background = xmlDocument.SelectSingleNode("Level/Background").InnerText;
		level.Road = xmlDocument.SelectSingleNode("Level/Road").InnerText;
		//将字符串数字转换成数字
		level.InitGold = int.Parse(xmlDocument.SelectSingleNode("Level/InitScore").InnerText);

		//声明一个临时的子节点数组.
		XmlNodeList nodeList;
		nodeList = xmlDocument.SelectNodes("Level/Holder/Point");


		//为level对象下的可放置武器列表赋值
		List<Point> tempList = new List<Point>();
		//遍历赋值
		for (int i = 0; i < nodeList.Count; i++)
		{
            System.Console.WriteLine(nodeList[i]);

			Point tempPoint = new Point
			(
				int.Parse(nodeList[i].Attributes["X"].Value),
				int.Parse(nodeList[i].Attributes["Y"].Value) 
			);
            System.Console.WriteLine(tempPoint);
			//将各个点添加到列表当中
			tempList.Add(tempPoint);
		}

		level.WeaponPos = tempList;

		//为level对象性的怪物路径列表赋值
		List<Point> tempMonsterRoute = new List<Point>();

		nodeList = xmlDocument.SelectNodes("Level/Path/Point");

		for (int i = 0; i < nodeList.Count; i++)
		{
			Point tempPoint = new Point
			(
				int.Parse(nodeList[i].Attributes["X"].Value),
				int.Parse(nodeList[i].Attributes["Y"].Value) 
			);

			//将各个点添加到列表当中
			tempMonsterRoute.Add(tempPoint);
		}

		level.MonsterRoute = tempMonsterRoute;

	//为level对象下的出怪回合列表赋值
		List<Round> tempRounds = new List<Round>();


		nodeList = xmlDocument.SelectNodes("Level/Rounds/Round");

		for (int i = 0; i < nodeList.Count; i++)
		{
			Round tempRound = new Round
			(
				int.Parse(nodeList[i].Attributes["Monster"].Value),
				int.Parse(nodeList[i].Attributes["Count"].Value) 
			);

			//将各个点添加到列表当中
			tempRounds.Add(tempRound);
		}


		level.Rounds = tempRounds;

		//赋值完成后, 需要关闭流
		stream.Close();
		stream.Dispose();
	}


	//将已经编辑好的Level类写入到文件中保存到本地.
	public static void SaveLevel(string fileName, Level level)
	{

		//通过stringBuilder对level类进行拼接
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
		stringBuilder.AppendLine("<Level>");
		stringBuilder.AppendLine(string.Format("<Name>{0}</Name>", level.Name));
		stringBuilder.AppendLine(string.Format("<CardImage>{0}</CardImage>", level.CardImage));
		stringBuilder.AppendLine(string.Format("<Background>{0}</Background>", level.Background));
		stringBuilder.AppendLine(string.Format("<Road>{0}</Road>", level.Road));
		stringBuilder.AppendLine(string.Format("<InitScore>{0}</InitScore>", level.InitGold));

		stringBuilder.AppendLine("<Holder>");
		for (int i = 0; i < level.WeaponPos.Count; i++)
		{
			stringBuilder.AppendLine(string.Format("<Point X=\"{0}\" Y=\"{1}\"/>", level.WeaponPos[i].X, level.WeaponPos[i].Y));
		}
		stringBuilder.AppendLine("</Holder>");

		stringBuilder.AppendLine("<Path>");
		for (int i = 0; i < level.MonsterRoute.Count; i++)
		{
			stringBuilder.AppendLine(string.Format("<Point X=\"{0}\" Y=\"{1}\"/>", level.MonsterRoute[i].X, level.MonsterRoute[i].Y));
		}
		stringBuilder.AppendLine("</Path>");

		stringBuilder.AppendLine("<Rounds>");
		for (int i = 0; i < level.Rounds.Count; i++)
		{
			stringBuilder.AppendLine(string.Format("<Round Monster=\"{0}\" Count=\"{1}\"/>", level.Rounds[i].MonsterID, level.Rounds[i].Count));
		}
		stringBuilder.AppendLine("</Rounds>");
        stringBuilder.AppendLine("</Level>");
		
		//将上面拼接的字符串转换成string对象
		string content = stringBuilder.ToString();

		// 格式化XML, 使其更美观
		XmlWriterSettings  writerSettings = new XmlWriterSettings();
		writerSettings.Indent = true;
		writerSettings.ConformanceLevel = ConformanceLevel.Auto;
		writerSettings.IndentChars = "\t";
		writerSettings.OmitXmlDeclaration = false;

		XmlWriter writer = XmlWriter.Create(fileName, writerSettings);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(content);
		xmlDocument.WriteTo(writer);

		writer.Flush();
		writer.Close();

	}


    public static IEnumerator LoadImage(string url,SpriteRenderer renderer)
    {
        WWW www = new WWW(url);

        while (!www.isDone)
        {
            yield return www;
        }

        Texture2D texture = www.texture;
        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));

        renderer.sprite = sprite;

    }
    public static IEnumerator LoadImage(string url, Image image)
    {
        WWW www = new WWW(url);

        while (!www.isDone)
        {
            yield return www;
        }

        Texture2D texture = www.texture;
        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));

		Debug.LogWarning(texture);
        image.sprite = sprite;

    }
}

