using database;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
using ToDoList mytodos=new ToDoList();
using ToDoList PageAcount=new ToDoList();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/Hello", () => "Hello World!");
app.MapGet("/ToDo",()=>mytodos.todos.ToArray());
app.MapPost("/creatToDo",(TODo t)=>creattodo(t)
);
app.MapPut("/editTodo",(int id,string nTitle,string nDetail,DateTime nMake,DateTime nDuedate)=>
{foreach(var t in mytodos.todos.ToArray()){if(t.Id==id)
{
    t.Title=nTitle;
    t.Details=nDetail;
    t.DateMake=nMake;
    t.DueDate=nDuedate;
    mytodos.SaveChanges();

}}});
app.MapDelete("/deleteToDo",(int id)=>{foreach(var t in mytodos.todos.ToArray())
{
    if(t.Id==id)
    {
        mytodos.todos.Remove(t);mytodos.SaveChanges();
    }
}}
);

app.MapGet("/Page",()=>PageAcount.PageAcount.ToArray()
);
app.MapPost("/creatpage",(mypage p)=>{PageAcount.PageAcount.Add(p);PageAcount.SaveChanges();}
);
app.MapPut("/editpage",(int id,string username,string interes,string interes2,string interes3)=>
{foreach(var t in PageAcount.PageAcount.ToArray()){if(t.ID==id)
{
    t.PageName=username;
    t.Interested=interes;
    t.Interested1=interes3;
    t.Interested2=interes2;

    PageAcount.SaveChanges();

}}});
app.MapDelete("/deletepage",(int id)=>{foreach(var t in PageAcount.PageAcount.ToArray())
{
    if(t.ID==id)
    {
       PageAcount.PageAcount.Remove(t);PageAcount.SaveChanges();
    }
}}
);
app.Run();
void creattodo(TODo t)
{
    mytodos.todos.Add(t);
    mytodos.SaveChanges();
}
