namespace database;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

public class TODo
{
    // public List<TODo> Tasks{get;set;}
    public TODo(){}
    public TODo(string title,string detail,DateTime DateMake,DateTime duedate,bool iscompleted,int id)
    {
        this.Title=title;this.DateMake=DateMake;this.Id=id;this.Details=detail;this.DueDate=duedate;
        this._IsCompleted=iscompleted;
    }
    public string Title {get;set;}
    public string Details {get;set;}
    public DateTime DateMake{get;set;}
    public DateTime DueDate{ get; set; }
    private bool _IsCompleted{get;set;}
    public bool IsCompleted {get;set;}
    public int Id{get;set;}
    public void AddTask(TODo newTodo)
    {
        List<TODo> Tasks=new List<TODo>();
        Tasks.Add(newTodo);
    }
    public TODo SearchByID(int id)
    {
        List<TODo> Tasks=new List<TODo>();
       return Tasks.Find(x=>x.Id==id);
    }
    public void RemoveTask(int iD)
    {
        List<TODo> Tasks=new List<TODo>();
        var t=SearchByID(iD);
        if(t!=null)
            Tasks.Remove(t);
    }
}
public class mypage
{
    public mypage(){}
    public mypage(string namepage,int passpage,string interested,string interested1,string interested2){this.PageName=namepage;
    this.ID=passpage;this.Interested=interested;this.Interested1=interested1;this.Interested2=interested2;}
    public string PageName{get;set;}
    [Key]
    public int ID{get;set;}
    public string Interested{get;set;}
    public string Interested1{get;set;}
    public string Interested2{get;set;}
    // public List<TODo> todo{get;set;}
}
public record TODO( int Id,string Title,string Details,DateTime DateMake,
DateTime DueDate,DateTime DateCompleted,bool IsCompleted);
public class ToDoList:DbContext
{
     public DbSet<mypage> PageAcount{get;set;}
    public DbSet<TODo> todos{get;set;}
    // public DbSet<TODO> todos{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite(@"Data Source=data.db");
    }

}
