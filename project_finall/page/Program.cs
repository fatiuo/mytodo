using project.Client;
// using ToDoList todos=new ToDoList();
using HttpClient httpClient = new HttpClient();
swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);

Console.WriteLine("Hello User");
while(true)
{
Console.WriteLine("select an option:");
Console.WriteLine("1:creat an Account  2:edit my page  3:delete page  4:mypages   5:exit");
        int firstanswer = int.Parse(Console.ReadLine());
        {
            if (firstanswer == 1)
            {

                Console.WriteLine("enter your username:");
                string uname = Console.ReadLine();

                    Console.WriteLine("enter your password:");
                    int upass = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter your interested:");
                    string enjoy = Console.ReadLine();
                    Console.WriteLine("enter your interested:");
                    string enjoy1 = Console.ReadLine();
                    Console.WriteLine("enter your interested:");
                    string enjoy2 = Console.ReadLine();
                    await client.CreatpageAsync(new Mypage(uname,upass, enjoy,enjoy1,enjoy2));

            }
            if (firstanswer == 2)
            {
                    Console.WriteLine("enter your password:");
                    int upass = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your new username:");
                string uname = Console.ReadLine();
                    Console.WriteLine("enter your new interested:");
                    string enjoy = Console.ReadLine();
                    Console.WriteLine("enter your  new interested:");
                    string enjoy1 = Console.ReadLine();
                    Console.WriteLine("enter your new interested:");
                    string enjoy2 = Console.ReadLine();
                    await client.EditpageAsync(upass,uname,enjoy,enjoy1,enjoy2);
            }
            if (firstanswer == 3)
            {
                    Console.WriteLine("enter your password:");
                    int upass = int.Parse(Console.ReadLine());
                    await client.DeletepageAsync(upass) ;  
            }
            if (firstanswer == 4)
                foreach (var t in client.PageAsync().Result)
                {
                        Console.WriteLine($"{t.Id} is{t.PageName}");
                }
              if(firstanswer==5)
              {
                Console.Write("thanks");
                break;
              }

        }
}
