using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class Controller 
{
    //需要继承了该基类的子类必须实现的方法.
    public abstract void Excute(object data);

    //获取到View与Model的方法
    public T GetModel<T>() where T: Model
    {
        return MVC.GetModel<T>();
    }

    public T GetView<T>() where T: View
    {
        return MVC.GetView<T>();
    }

    //注册
    protected void RegisterView(View view)
    {
        MVC.RegisterView(view);
    }

    protected void RegisterModel(Model model)
    {
        MVC.RegisterModel(model);
    }

    protected void RegisterController(string name, Type controller)
    {
        MVC.RegisterController(name, controller);
    }

}