using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System.Xml;
using UnityEngine.UI;


//工具类, 用来保存读取Level
public class Tools 
{

    //访问目录, 把所有的.xml遍历.  
    public static List<FileInfo> GetLevelFiels()
    {
        string[] fiels = Directory.GetFiles(Const.LevelPath, "*.xml");

        List<FileInfo> list  = new List<FileInfo>();

        //遍历文件夹下的每一个关卡文件, 将其添加到List当中
        for (int i = 0; i < fiels.Length; ++ i)
        {
            FileInfo fileInfo = new FileInfo(fiels[i]);

            list.Add(fileInfo);
        }

        return list;
    }

    //通过文件名, 获取到xml文件. 并将这个文件的内容填充到Level类中
    public static void FillLevelFromFile(string fileName, ref Level level)
    {
        //通过文件名, 得到这个文件
        FileInfo file = new FileInfo(fileName);

        //创建一个流, 以只读方式打开 编码为UTF8
        StreamReader stream = new StreamReader(file.OpenRead(), Encoding.UTF8);

        //创建一个XML文件
        XmlDocument document = new XmlDocument();

        //向Xml文件对象中, 导入流
        document.Load(stream);
        //从Xml文件中, 向Level类中填充数据

        level.Name = document.SelectSingleNode("/Level/Name").InnerText;
        level.Background = document.SelectSingleNode("/Level/Background").InnerText;
        level.Road = document.SelectSingleNode("/Level/Road").InnerText;
        level.InitGold = int.Parse(document.SelectSingleNode("/Level/InitScore").InnerText);


        //现在是遍历每一个节点中的数组元素, 添加到Level中的属性当中

        //声明一个临时的List
        XmlNodeList list;

        //读取可安放武器的点
        list = document.SelectNodes("/Level/Holder/Point");

        for (int i = 0; i < list.Count; i++)
        {
            //获取每一个点, 并添加到level的可安放炮塔的位置列表当中
            XmlNode node = list[i];


            //根据每一个xml的结点内的属性, 生成一个点
            Point point = new Point(int.Parse(node.Attributes["X"].Value),
                                    int.Parse(node.Attributes["Y"].Value));



            //得到点后, 添加到Level类中对应的属性当中
            level.WeaponPos.Add(point);

        }

        //读取怪物的行进路线点
        list = document.SelectNodes("/Level/Path/Point");

        //遍历
        for (int i = 0; i < list.Count; ++i)
        {
            //获取每一个结点
            XmlNode node = list[i];

            //生成点
            Point point = new Point(int.Parse(node.Attributes["X"].Value),
                                    int.Parse(node.Attributes["Y"].Value));

            //添加到level类中的路径属性当中
            level.Path.Add(point);
        }


        //读取xml文件中的Rounds
        list = document.SelectNodes("/Level/Rounds/Round");


        //遍历
        for (int i = 0; i < list.Count;++ i)
        {
            XmlNode node = list[i];

            Round round = new Round(int.Parse(node.Attributes["Monster"].Value),
                                    int.Parse(node.Attributes["Count"].Value));

            //添加到Round列表当中
            level.Rounds.Add(round);
        }


        //读取完之后, 关闭流
        stream.Close();
        stream.Dispose();
    }

    //将已经编辑好的Level类, 写入到文件当中
    public static void WriteLevelToFile(string fielName, Level level)
    {

        StringBuilder builder = new StringBuilder();
        //反向操作.
        builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf - 8\"?>");
        //将需要操作的字符串拼接后, 写入到文件
        //添加文件头

        //根据所需要的格式添加写入到string
        builder.AppendLine("/Level");
        builder.AppendLine(string.Format("<Name>{0}</Name>", level.Name));
        //CardImage
        builder.AppendLine(string.Format("<CardImage>{0}</CardImage>", level.CardImage));
        //Background
        builder.AppendLine(string.Format("<Background>{0}</Background>", level.Background));
        //Road
        builder.AppendLine(string.Format("<Road>{0}</Road>", level.Road));
        //InitScore
        builder.AppendLine(string.Format("<InitScore>{0}</InitScore>", level.InitGold));


        //添加炮塔位置点
        builder.AppendLine(string.Format("<Holder>"));

        for (int i = 0; i < level.WeaponPos.Count;++i)
        {
            builder.AppendLine(string.Format("<Point X=\"{0}\" Y=\"{1}\" />", level.WeaponPos[i].X, level.WeaponPos[i].Y));
        }

        builder.AppendLine(string.Format("</Holder>"));

        //添加Path结点s
        builder.AppendLine(string.Format("<Path>"));

        for (int i = 0; i < level.WeaponPos.Count; ++i)
        {
            builder.AppendLine(string.Format("<Point X=\"{0}\" Y=\"{1}\" />", level.Path[i].X, level.Path[i].Y));
        }

        builder.AppendLine(string.Format("</Path>"));


        //添加回合结点s
        builder.AppendLine(string.Format("<Round>"));

        for (int i = 0; i < level.WeaponPos.Count; ++i)
        {
            builder.AppendLine(string.Format("<Point X=\"{0}\" Y=\"{1}\" />", level.Rounds[i].MonsterID, level.Rounds[i].Count));
        }

        builder.AppendLine(string.Format("</Round>"));

        builder.AppendLine("</Level>");
        //转换
        string content = builder.ToString();

        //创建输入流对象
        StreamWriter writer = new StreamWriter(fielName, false,  Encoding.UTF8);

        //写入
        writer.Write(content);

        //刷新
        writer.Flush();
        //关闭  
        writer.Dispose();

    }


    public static IEnumerator LoadImage(string url, SpriteRenderer renderer)
    {
        WWW www = new WWW(url);

        while (!www.isDone)
            yield return www;


        Texture2D texture = www.texture;

        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));

        renderer.sprite = sprite;
    }


    public static IEnumerator LoadImage(string url, Image renderer)
    {
        WWW www = new WWW(url);

        while (!www.isDone)
            yield return www;


        Texture2D texture = www.texture;

        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));

        renderer.sprite = sprite;
    }

}
