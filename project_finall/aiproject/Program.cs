
using OpenAI_API;
using OpenAI_API.Completions;
var openai = new OpenAIAPI("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");
CompletionRequest completionRequest = new CompletionRequest();

    // while(true)
    // {
    //     Console.Write("Query? ");
    //     string query = Console.ReadLine();
    //     Console.Write("Query? ");
    //     string task = Console.ReadLine();
    //     // string[]tasks={"study mathe","paint my room","buy a book"};
    //     var result =Stress(task);
    //     System.Console.WriteLine(result.Result);
    // }
    while (true)
    {
    Console.Write("choose:1:InspireForTask    2:MakeMotivation  3: BuldSkill  4:Stress    5:exit");
    int answr=int.Parse(Console.ReadLine());
    if (answr==1)
    {
        Console.Write("write your hobby:");
        string inter=Console.ReadLine();
        Console.Write("write your  task that you should to do:");
        string task=Console.ReadLine();
        await InspireForTask(inter,task);
    }
    if (answr==2)
    {
        Console.Write("write your task :");
        string task=Console.ReadLine(); 
        await MakeMotivation(task); 
    }
    if (answr==3)
    {
        Console.Write("write your task :");
        string task=Console.ReadLine(); 
        await BuildSkill(task);
    }

    if (answr==4)
    {
        Console.Write("write your task :");
        string task=Console.ReadLine(); 
        await Stress(task);
    }
    if(answr==5)
    {
        Console.Write("tanks");
        break;
    }
    }
    async Task<string> InspireForTask(string interested,string task)
    {

        string outputResult = "";
        completionRequest.Prompt = $"i am interested in{interested}but i cant do this because i should do{task} can you give me a idea for doing my {task} when i do my {interested} too";
        completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
        completionRequest.MaxTokens = 1024;

        var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

        foreach (var completion in completions.Completions)
        {
            outputResult += completion.Text;
        }

         Console.Write(outputResult);
         return outputResult;
    }
    async Task<string> MakeMotivation(string task)
    {
        string outputResult = "";
        completionRequest.Prompt = $"i dont have motivation to do my {task} can you give me a motivation for doing my{task}";
        completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
        completionRequest.MaxTokens = 1024;

        var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

        foreach (var completion in completions.Completions)
        {
            outputResult += completion.Text;
        }

         Console.Write(outputResult);
         return outputResult;
    }
    async Task<string> BuildSkill(string task)
    {
        string outputResult = "";
        completionRequest.Prompt = $"i think i dont have enough skill and knowlage to do {task} cn you give me a solution";
        completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
        completionRequest.MaxTokens = 1024;

        var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

        foreach (var completion in completions.Completions)
        {
            outputResult += completion.Text;
        }

         Console.Write(outputResult);
         return outputResult;
    }
    async Task<string> Stress(string task)
    {
        string outputResult = "";
        completionRequest.Prompt = $"i have stress for doing{task} can you give me a solution for decreas my stress";
        completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
        completionRequest.MaxTokens = 1024;

        var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

        foreach (var completion in completions.Completions)
        {
            outputResult += completion.Text;
        }

        Console.Write(outputResult);
        return outputResult;
    
    }
    
