using NotificationNamespace;
using PostNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserNamespace;

namespace AdminNamespace
{
    internal class Admin
    {
        public int Id { get; set; }
        public static int StaticId = 1;
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }


        public List<Post> posts = new();

        public List<Notification> Notifications = new();

        public Admin(string? username,string email,string password)
        {
            Id = StaticId++;
            Username = username;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"Id: {Id} \nUsername: {Username} \nEmail: {Email} \nPassword: {Password}"; 
        }


        public void AddPost(Post post)
        {
            posts.Add(post);
        }

        public void AddNotication(Notification noti)
        {
            Notifications.Add(noti);
        }

        public void ShowPosts()
        {
            foreach (var post in posts)
            {
                Console.WriteLine(post);
                post.VeiwCount++;
            }
        }

        public void ShowNotifications()
        {
            foreach (var noti in Notifications)
            {
                Console.WriteLine(noti);
            }
        }

        public void LikePostById(int Id)
        {
            foreach (var post in posts)
            {
                if (post.Id == Id)
                {
                    post.LikeCount++;
                    Console.WriteLine(post);
                }
            }
        }

        public void AddNotification(int Id, string text, User user)
        {
            foreach (var post in posts)
            {
                if (post.Id == Id)
                {
                    Notification noti = new(text, user);
                    Notifications.Add(noti);
                }
            }
        }

    }
}
