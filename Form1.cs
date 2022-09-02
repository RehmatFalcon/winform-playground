using Dapper;
using Playground.Forms;
using Playground.Models;
using System.ComponentModel;
using System.Data;

namespace Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load; ;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            submitBtn.Click += SubmitBtn_Click;
        }

        private void SubmitBtn_Click(object? sender, EventArgs e)
        {
            var username = usernameElm.Text;
            var password = usernameElm.Text;

            // Check if username has been input
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input username");
                return;
            }

            // Check from database
            if(IsUserPasswordSame(username, password))
            {
                var dashboard = new Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                //dashboard.Show();
                Show();
                //Close();
            }
            else
            {
                MessageBox.Show("Username/password incorrect");
            }
        }

        private bool IsUserPasswordSame(string username, string password)
        {
            // get connection
            var hashed = BCrypt.Net.BCrypt.HashPassword("admin");
            usernameElm.Text = hashed;
            using var conn = ConnectionProvider.GetDbConnection();

            // Define query
            var query = $"SELECT * FROM `user` WHERE Name = @user_name;";

            // Execution
            var user = conn.QueryFirstOrDefault<User>(query, new {
                user_name = username 
            });
            if (user == null) return false;
            else return true;
        }
    }
}