using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Tennisklubben.DataConnection;
using Tennisklubben.Models;

namespace Tennisklubben
{
    public class PlayerManager
    {
        Player player;
        public PlayerManager(Player player)
        {
            this.player = player;
        }
        DbConnection db = new DbConnection();
        public void CreatePlayer()
        {
            
            db.SaveToDatabase(player.Name, player.Adress, player.Phone, player.Email, player.Age, player.RegDate, player.CreditCard, player.Username, player.Password);
        }
    }
}