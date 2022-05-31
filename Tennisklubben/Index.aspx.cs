using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tennisklubben.DataConnection;
using Tennisklubben.Models;

namespace Tennisklubben
{
    public partial class Index : System.Web.UI.Page
    {
        Player player;
        PlayerManager playermng;
        Validator validator;
        protected void Page_Load(object sender, EventArgs e)
        {
            player = new Player();
            playermng = new PlayerManager(player);
            validator = new Validator();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            player.Username = TextBoxUsername.Text;
            player.Password = TextBoxPassword.Text;
            player.Name = TextBoxName.Text;
            player.Email = TextBoxEmail.Text;
            player.Phone = TextBoxPhone.Text;
            player.Adress = TextBoxAdress.Text;
            player.Age = int.Parse(TextBoxAge.Text);
            player.RegDate = DateTime.Parse(TextBoxRegDate.Text);
            player.CreditCard = TextBoxCreditCard.Text;
            validator.ValidateCreditCard(player.CreditCard);
            playermng.CreatePlayer();

        }
    }
}