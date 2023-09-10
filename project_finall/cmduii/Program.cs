// using database;

using project.Client;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR.Client;

// using ToDoList todos=new ToDoList();
using HttpClient httpClient = new HttpClient();
swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
// var con=new HubConnectionBuilder ().WithUrl("http://localhost:5000/chathub").Build();
// con.StartAsync().Wait();
Console.WriteLine("hello welcome ");
while (true)
{
Console.WriteLine("enter a number:");
Console.WriteLine("1:make TODO   ,   2:delete TODO   ,   3:edite TODO   ,      4:show todo    ,  5:exit");
int answer=int.Parse(Console.ReadLine());
if(answer==1)
{

    Console.WriteLine("choose a name for your ToDo:");
    string todoname=Console.ReadLine();
    Console.WriteLine("choose a id for your ToDo:");
    int todoid=int.Parse(Console.ReadLine());
    Console.WriteLine("please write your todo details:");
    string tododetail=Console.ReadLine();
    Console.WriteLine("how many days you have until you duedate?");
    int days=int.Parse(Console.ReadLine());
    TODo t=new TODo(todoname,tododetail,DateTime.Now,DateTime.Now.AddDays(days),false,todoid);
    await client.CreatToDoAsync(new TODo(todoname,tododetail,DateTime.Now,DateTime.Now.AddDays(days),false,todoid));
    // con.StartAsync().Wait();
    // con.On("creatToDo",(TODo t) => client.CreatToDoAsync(new TODo(todoname,tododetail,DateTime.Now,DateTime.Now.AddDays(days),false,todoid)));
    // con.InvokeAsync("addtodolist").Wait();
    // con.StopAsync().Wait();

}
if(answer==2)
{
    Console.WriteLine("enter your id ");
    int todoid=int.Parse(Console.ReadLine());
    await client.DeleteToDoAsync(todoid);
    // con.On("deleteToDo",(int id)=>client.DeleteToDoAsync(todoid);});
    // con.InvokeAsync("addtodolist").Wait();
    // con.StopAsync().Wait();
}
if (answer==3)
{
    Console.WriteLine("enter your id ");
    int todoid=int.Parse(Console.ReadLine());
    TODo t=SearchByID(todoid);
        Console.WriteLine("enter your new title:");
        string newtitle=(Console.ReadLine());
        Console.WriteLine("enter your new dtail:");
        string newdetail=(Console.ReadLine());

        Console.WriteLine("enter your new makedate:");
        string newdete1=(Console.ReadLine());
        Console.WriteLine("enter your new duedate:");
        string newdete2=(Console.ReadLine());
        await client.EditTodoAsync(todoid,newtitle,newdetail,newdete1,newdete2);
    // con.On("EditTodo",int todoid,string newtitle,string newdetail,string newdete1,string newdete2=>await client.EditTodoAsync(todoid,newtitle,newdetail,newdete1,newdete2);});
    // con.InvokeAsync("addtodolist").Wait();
    // con.StopAsync().Wait();
}
if (answer==4)
{
    foreach(var t in client.ToDoAsync().Result)
    {
        Console.WriteLine($"{t.Id}is{t.Title}&{t.Details}&have time until{t.DueDate}");
    }
    // con.On("ToDoAsync",()=>client.ToDoAsync();});
    // con.InvokeAsync("addtodolist").Wait();
    // con.StopAsync().Wait();
}
if(answer==5)
{
    Console.WriteLine("thanke you.");
    break;
}
}
    void AddTask(TODo newTodo)
    {
        List<TODo> Tasks=new List<TODo>();
        Tasks.Add(newTodo);
    }
    TODo SearchByID(int id)
    {
        List<TODo> Tasks=new List<TODo>();
       return Tasks.Find(x=>x.Id==id);
    }
    void RemoveTask(int iD)
    {
        List<TODo> Tasks=new List<TODo>();
        var t=SearchByID(iD);
        if(t!=null)
            Tasks.Remove(t);
    }
