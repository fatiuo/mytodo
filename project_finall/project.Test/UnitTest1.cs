namespace project.Test;
using System;using project.Client;

using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void add()
    {
    HttpClient httpClient = new HttpClient();
    swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
    TODo t=new TODo("ap","project",DateTime.Now,DateTime.Now.AddDays(12),false,60);
    TODo t1=new TODo("ap1","project",DateTime.Now,DateTime.Now.AddDays(12),false,61);
    TODo t2=new TODo("ap2","project3",DateTime.Now,DateTime.Now.AddDays(14),false,62);
        client.CreatToDoAsync(t);
        client.CreatToDoAsync(t1);
        client.CreatToDoAsync(t2);
        TODo[]todo=client.ToDoAsync().Result.ToArray();
        foreach(var m in todo)
        {
            if(m.Id==60)
            {
                Assert.AreEqual(t.Title,"ap");

            }
        }

    }
    [TestMethod]
    public void edit()
    {
    HttpClient httpClient = new HttpClient();
    swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
    TODo t=new TODo("ap","project",DateTime.Now,DateTime.Now.AddDays(12),false,63);
    TODo t1=new TODo("ap1","project",DateTime.Now,DateTime.Now.AddDays(12),false,64);
    TODo t2=new TODo("ap2","project3",DateTime.Now,DateTime.Now.AddDays(14),false,65);
        client.CreatToDoAsync(t);
        client.CreatToDoAsync(t1);
        client.CreatToDoAsync(t2);
        client.EditTodoAsync(63,"math","exam","11/11/2014","12/11/2014");
        TODo[]todo=client.ToDoAsync().Result.ToArray();
        
        foreach(var m in todo)
        {
            if(m.Id==63)
            {
                Assert.AreEqual(m.Title,"math");
                Assert.AreEqual(m.Details,"exam");

            }
        }

    }
}