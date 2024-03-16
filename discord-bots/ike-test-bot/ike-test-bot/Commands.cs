using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ike_test_bot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        //[Command("")]
        //public async Task generateText(int amtOfWords)
        //{
        //    MarkovChain mc = new MarkovChain();
        //    var msgs = await Context.Channel.GetMessagesAsync(500).FlattenAsync();
        //    StringBuilder strB = new StringBuilder();
        //    foreach(var msg in msgs)
        //    {
        //        strB.Append(msg.Content.Replace(".", "").Replace(",", "") + " ");
        //    }
        //    await Context.Channel.SendMessageAsync(mc.generateText(amtOfWords, strB.ToString()));
        //}
    }
}
