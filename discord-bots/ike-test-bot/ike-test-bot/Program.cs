using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ike_test_bot
{
    public class Program
    {
        private DiscordSocketClient client;
        public CommandService Commands;
        private IServiceProvider services;
        //public static ulong henryId = 315372416014745600;
        //public bool toggle = true;

        public int AngeryCounter = 0;
        public Random gen = new Random();

        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug,
                AlwaysDownloadUsers = true,
                MessageCacheSize = 100
            });

            Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug
            });

            services = new ServiceCollection()
                .AddSingleton(this)
                .AddSingleton(client)
                .AddSingleton(Commands)
                .AddSingleton<Commands>()
                .AddSingleton<ConfigHandler>()
                .BuildServiceProvider();

            await services.GetService<ConfigHandler>().FillConfig();

            client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), services);

            client.Log += Client_Log;
            client.Ready += Client_Ready;
            client.GuildMemberUpdated += Client_GuildMemberUpdated;

            await client.LoginAsync(TokenType.Bot, services.GetService<ConfigHandler>().GetToken());
            await client.StartAsync();

            await Task.Delay(-1);
        }

        private async Task Client_GuildMemberUpdated(SocketGuildUser arg1, SocketGuildUser arg2)
        {
            //if (arg1.Id == henryId)
            //{
            //    if (!arg1.Nickname.ToLower().Contains("king"))
            //    {
            //        var prevName = arg1.Nickname;
            //        await arg1.ModifyAsync(x =>
            //        {
            //            x.Nickname = "King " + prevName;
            //        });
            //    }
            //}
        }

        private async Task Client_Ready()
        {
            await client.SetGameAsync("text generation");
        }

        private async Task Client_Log(LogMessage arg)
        {
            Console.WriteLine($"{DateTime.Now} at {arg.Source}] {arg.Message}");
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(client, Message);
            var currUser = Context.Channel.GetUserAsync(client.CurrentUser.Id).Result;

            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.Message.Author.IsBot) return;

            int ArgPos = 0;

            if(!Message.HasMentionPrefix(client.CurrentUser, ref ArgPos) && !(Message.HasStringPrefix("ikebot", ref ArgPos)))
            {
                return;
            }

            //if (Message.HasMentionPrefix(client.CurrentUser, ref ArgPos) && Message.Content.ToLower().Contains("toggle"))
            //{
            //    toggle = !toggle;
            //}

            //if (Message.Author.Id == henryId && toggle)
            //{
            //    AddKing(Message);
            //}

            Random rand = new Random();
            await Context.Channel.TriggerTypingAsync();
            genText(Context, rand.Next(3, 41));

            //var result = await Commands.ExecuteAsync(Context, ArgPos, services);

            //if (!result.IsSuccess)
            //{
            //    Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {Context.Message.Content} | Error: {result.ErrorReason}");
            //    if (result.ErrorReason == "User requires guild permission Administrator")
            //    {
            //        await Context.Channel.SendMessageAsync("Only admins can use that command!");
            //    }
            //    else
            //    {
            //        await Context.Channel.SendMessageAsync("That's not a command.");
            //    }
            //}


        }

        //private async void AddKing(SocketUserMessage msg)
        //{
        //    //var k = new Emoji("🇰");
        //    //var i = new Emoji("🇮");
        //    //var n = new Emoji("🇳");
        //    //var g = new Emoji("🇬");
        //    Emoji[] emotes = new Emoji[] { new Emoji("🇰"), new Emoji("🇮"), new Emoji("🇳"), new Emoji("🇬") };
        //    for (int i = 0; i < emotes.Length; i++)
        //    {
        //        await msg.AddReactionAsync(emotes[i]);
        //    }
        //}

        private async void genText(SocketCommandContext Context, int amtOfWords)
        {
            MarkovChain mc = new MarkovChain();
            var msgs = await Context.Channel.GetMessagesAsync(100).FlattenAsync();
            StringBuilder strB = new StringBuilder();
            foreach (var msg in msgs)
            {
                if (msg.Content.Contains("ikebot"))
                    continue;
                strB.Append(msg.Content.Replace(".", "").Replace(",", "") + " ");
            }
            strB.Replace("ikebot", "");
            await Context.Channel.SendMessageAsync(mc.generateText(amtOfWords, strB.ToString()));
        }
    }
}