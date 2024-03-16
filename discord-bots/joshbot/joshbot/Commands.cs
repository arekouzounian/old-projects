using Discord.Commands;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using System.Linq;

namespace joshbot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("toJosh"), Alias("joshify", "reJosh"),
            RequireUserPermission(GuildPermission.ChangeNickname)]
        public async Task reJosh()
        {
            var users = await Context.Channel.GetUsersAsync().FlattenAsync();
            foreach (var user in users)
            {
                if (user == Context.Guild.Owner || user == Program.findJosh() || user.Id == 220710429083697152)
                {
                    continue;
                }
                await (user as SocketGuildUser).ModifyAsync(x =>
                {
                    x.Nickname = "josh";
                });
            }
            await Context.Channel.SendMessageAsync("Josh planted.");
        }

        [Command("show us Josh"), Alias("who is Josh")]
        public async Task showJosh()
        {
            var Josh = Program.findJosh();
            await Context.Channel.SendMessageAsync($"{Josh.Mention} is the current Josh.");
        }

        [Command("newJosh"), RequireUserPermission(GuildPermission.Administrator)]
        public async Task newJosh()
        {
            var NewJosh = Program.newJosh(Program.findJosh());
            await Program.gContext.Channel.SendMessageAsync($"{NewJosh.Mention}, you are this week's josh.");
        }

        [Command("m"), RequireUserPermission(GuildPermission.Administrator)]
        [RequireOwner]
        public async Task m(int amt = 50)
        {
            await Context.Channel.SendMessageAsync($"From {Context.Message.Author.Username}:");
            await Context.Channel.SendMessageAsync("m");
            SocketGuildUser happy = Program.client.GetGuild(715798257661509743).GetUser(261539060940668928);
            for (int i = 0; i < amt; i++)
            {
                await happy.SendMessageAsync("m");
            }
        }

        [Command("onlyJosh"), Alias("scrub", "josh"), RequireUserPermission(GuildPermission.Administrator)]
        public async Task scrubChat(int amt = 50)
        {
            var messages = await Context.Channel.GetMessagesAsync(amt).FlattenAsync();
            foreach (var message in messages)
            {
                if (!(message.Content.ToLower() == "josh"))
                {
                    await message.DeleteAsync();
                }
            }
            await Context.Message.DeleteAsync();
        }

        [Command("Genesis")]
        [RequireOwner]
        public async Task newServer(string guildName = "Jahbot's Corner")
        {
            var voiceRegion = await Context.Guild.GetVoiceRegionsAsync();
            var vR = voiceRegion.First();
            var guild = await Program.client.CreateGuildAsync(guildName, vR);
            await Context.Channel.SendMessageAsync("Making the server...");
            var newChannel = await guild.CreateTextChannelAsync("welcome");
            var invite = await newChannel.CreateInviteAsync(null);
            await Context.Channel.SendMessageAsync(invite.Url);
            ; //break pt here 
            await guild.DeleteAsync();
        }

        [Command("hi")]
        public async Task hi()
        {
            Context.Channel.EnterTypingState();
        }

        [Command("deleteServer")]
        [RequireOwner]
        public async Task youFuckedUp(ulong id)
        {
            var guild = Program.client.GetGuild(id);
            await guild.DeleteAsync();
        }
    }
}

