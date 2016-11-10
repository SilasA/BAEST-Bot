using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Net;
using Discord;

namespace BAEST_Bot
{
    /// <summary>
    /// 
    /// </summary>
    class Bot
    {
        private DiscordClient client;

        /// <summary>
        /// 
        /// </summary>
        public Bot()
        {
            client = new DiscordClient();
            client.MessageReceived += async (s, e) =>
            {
                if (!e.Message.IsAuthor)
                    await e.Channel.SendMessage(e.Message.Text);
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            //Convert our sync method to an async one and block the Main function until the bot disconnects
            client.ExecuteAndWait(async () =>
            {
                //Connect to the Discord server using our email and password
                await client.Connect("discordtest@email.com", "Password123");
            });
        }
    }
}
