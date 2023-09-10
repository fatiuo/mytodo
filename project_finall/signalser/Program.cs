using Microsoft.AspNetCore.SignalR;
using project.Client;
var builder=WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app=builder.Build();
app.MapHub<chathub>("/chathub");//وقتی چتهاب صدا زده شد متد ها اجرا میشه\
app.Run();
public class chathub:Hub
{
    public async Task todolist()
    {
        await Clients.All.SendAsync("ToDo");
    }
    public async Task deletetodolist(int id)
    {
        await Clients.All.SendAsync("deleteToDo",id);
    }
    public async Task addtodolist(TODo t)
    {
        await Clients.All.SendAsync("creatToDo",t);
    }
    public async Task Edit(int id,string title,string detail,DateTime DateMake,DateTime duedate)
    {
        await Clients.All.SendAsync("editTodo",id,title,detail,DateMake,duedate);
    }
    public async Task pagelist()
    {
        await Clients.All.SendAsync("Page");
    }
    public async Task Addpagelist(string namepage,int passpage,string interested,string interested1,string interested2)
    {
        await Clients.All.SendAsync("creatpage",namepage,passpage,interested,interested1,interested2);
    }
    public async Task delpagelist(int id)
    {
        await Clients.All.SendAsync("deletepage",id);
    }
    public async Task ediipagelist(int id,string username,string interes,string interes2,string interes3)
    {
        await Clients.All.SendAsync("editpage",id,username,interes,interes2,interes3);
    }
}
