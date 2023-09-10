using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Net.Http;
using System.Text;
using System.Windows;
using Newtonsoft.Json;
using OpenAI_API;
using System.Threading.Tasks;
using OpenAI_API.Completions;

namespace wpfui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    public partial class TODO : Window

    public partial class open : Window
    {
        OpenAIAPI openai = new OpenAIAPI("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");
CompletionRequest completionRequest = new CompletionRequest();
        public open()
        {
            InitializeComponent();
            this.button.Click+=Stress;
            this.button1.Click+=MakeMotivation;
            this.button2.Click+=BuildSkill;
            
        }

        async void BuildSkill(object sender, EventArgs args)
        {
            string outputResult = "";

            OpenAIAPI openai = new OpenAIAPI("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");
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = $"i think i dont have enough skill and knowledge to do {this.UserInputTextBox.Text} can you give me a solution";
            completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            completionRequest.MaxTokens = 1024;

            var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                outputResult += completion.Text;
            }

            this.ChatTextBox.Text = outputResult;

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
            // تقسیم متن به خطوط
            string[] lines = textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            
            // تعداد کلمات در هر خط
            int[] wordCounts = lines.Select(line => line.Split('.').Length).ToArray();
            
            // نمایش تعداد کلمات در هر خط
            string result = string.Join(Environment.NewLine, wordCounts);
            MessageBox.Show(result);
        }

        async void MakeMotivation(object sender, EventArgs args)
        {
            string outputResult = "";

            OpenAIAPI openai = new OpenAIAPI("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");
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = $"i dont have motivation to do my {this.UserInputTextBox.Text} can you give me a motivation for doing my{this.UserInputTextBox.Text}";
            completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            completionRequest.MaxTokens = 1024;

            var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                outputResult += completion.Text;
            }

            this.ChatTextBox.Text = outputResult;

        }
        async void Stress(object sender, EventArgs args)
        {
            string outputResult = "";

            OpenAIAPI openai = new OpenAIAPI("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");
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt =$"i have stress for doing{this.UserInputTextBox.Text} can you give me a solution for decreas my stress";
            completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            completionRequest.MaxTokens = 1024;

            var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                outputResult += completion.Text;
            }

            this.ChatTextBox.Text = outputResult;

        }
    }
}
