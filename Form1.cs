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
            registerBtn.Click += RegisterBtn_Click;
        }

        private void RegisterBtn_Click(object? sender, EventArgs e)
        {
            var username = usernameElm.Text;
            var password = pwdTxt.Text;

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            
            // get connection
            var conn = ConnectionProvider.GetDbConnection();


            var userCountQuery = "SELECT count(*) FROM `user`;";
                
            var userCount = conn.QueryFirstOrDefault<int>(userCountQuery);

            if(userCount > 0)
            {
                MessageBox.Show("Multiple user registration not supported");
                return;
            }

            // define query
            var query = "INSERT INTO `user` (`Id`, `Name`, `password`) VALUES (NULL, @user_name, @user_password)";

            // Execute

            conn.Execute(query, new
            {
                user_name = username,
                user_password = hashedPassword,
            });
            MessageBox.Show("Registration Complete");
        }

        private void SubmitBtn_Click(object? sender, EventArgs e)
        {
            var username = usernameElm.Text;
            var password = pwdTxt.Text;

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
            using var conn = ConnectionProvider.GetDbConnection();

            // Define query
            var query = $"SELECT * FROM `user` WHERE Name = @user_name;";

            // Execution
            var user = conn.QueryFirstOrDefault<User>(query, new {
                user_name = username 
            });
            if (user == null) return false;
            else
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}