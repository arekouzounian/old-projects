using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace joshbot
{
    class Program
    {
        public static DiscordSocketClient client;
        public CommandService Commands;
        private IServiceProvider services;
        public static SocketCommandContext gContext;

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
                .AddSingleton<ConfigHandler>()
                .BuildServiceProvider();

            await services.GetService<ConfigHandler>().FillConfig();

            client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), services);

            client.Log += Client_Log;
            client.Ready += Client_Ready;
            client.UserJoined += Client_UserJoined;

            await client.LoginAsync(TokenType.Bot, services.GetService<ConfigHandler>().GetToken());
            await client.StartAsync();

            await Task.Delay(-1);
        }

        private async Task Client_UserJoined(SocketGuildUser user)
        {
            var joshRole2 = gContext.Guild.GetRole(716065561385238589);
            await user.AddRoleAsync(joshRole2);
        }

        private async Task Client_Ready()
        {
            await client.SetGameAsync("josh");
        }

        private async Task Client_Log(LogMessage arg)
        {
            Console.WriteLine($"{DateTime.Now} at {arg.Source}] {arg.Message}");
            if(DateTime.Now.Day == 1 && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 10)
            {
                var NewJosh = newJosh(findJosh());
                await gContext.Channel.SendMessageAsync($"{NewJosh.Mention}, you are this week's josh.");
            }
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(client, Message);
            gContext = Context;

            //if(isImage(Message.Attachments.Count, Message.Content))
            //{
            //    Console.WriteLine("it's an image");
            //}

            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.Message.Author.IsBot) return;

            int ArgPos = 0;

            if (!Message.HasMentionPrefix(client.CurrentUser, ref ArgPos))
            {
                return;
            }

            await Context.Channel.TriggerTypingAsync();

            var result = await Commands.ExecuteAsync(Context, ArgPos, services);

            if (!result.IsSuccess)
            {
                Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {Context.Message.Content} | Error: {result.ErrorReason}");
                if (result.ErrorReason == "User requires guild permission Administrator")
                {
                    await Context.Channel.SendMessageAsync("you're not josh :(");
                }
                else
                {
                    await Context.Channel.SendMessageAsync("wrong command, josh");
                }
            }
        }

        public static SocketGuildUser newJosh(SocketGuildUser currJosh)
        {
            IRole joshRole = gContext.Guild.GetRole(715798870256386131);
            var users = gContext.Guild.Users;
            List<SocketGuildUser> lUsers = new List<SocketGuildUser>();
            foreach(var user in users)
            {
                lUsers.Add(user);
            }
            Random gen = new Random();
            int index = gen.Next(0, lUsers.Count);
            while(lUsers[index] == currJosh || lUsers[index] == gContext.Guild.Owner || lUsers[index].Id == 220710429083697152)
            {
                index = gen.Next(0, lUsers.Count);
            }
            var newJosh = lUsers[index];
            newJosh.AddRoleAsync(joshRole);
            currJosh.RemoveRoleAsync(joshRole);

            return newJosh;
        }

        public static SocketGuildUser findJosh()
        {
            var joshRole = gContext.Guild.GetRole(715798870256386131);
            var users = gContext.Guild.Users;
            foreach (var user in users)
            {
                if (user == gContext.Guild.Owner || user.IsBot || user.Id == 220710429083697152)
                {
                    continue;
                }
                foreach (var role in user.Roles)
                {
                    if(role == joshRole)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        public static bool isImage(int attachmentCount, string messageContent)
        {
            if(attachmentCount > 0 && messageContent == "")
            {
                return true;
            }
            return false;
        }
    }
}
