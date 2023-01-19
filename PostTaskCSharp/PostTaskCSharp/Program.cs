using AdminNamespace;
using NotificationNamespace;
using PostNamespace;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography;
using UserNamespace;

Admin a1 = new("Togrul","togrul1609@gmail.com","1234");


Post p1 = new("post1");
Post p2 = new("post2");
Post p3 = new("post3");


User u1 = new("Elon","Musk",21,"elon@gmail.com","1234");
User u2 = new("Bill","Gates",22,"bill@gmail.com","4321");
User u3 = new("Vladimir","Putin",21,"elon@gmail.com","1234");

a1.AddPost(p1);
a1.AddPost(p2);
a1.AddPost(p3);

List<User> users = new();

users.Add(u1);
users.Add(u2);
users.Add(u3);


string? choose;
Console.WriteLine("1.Admin \n2.User");
choose = Console.ReadLine();

label:

if (choose == "1")
{
    string? username;
    string? password;
    Console.Clear();
    Console.WriteLine("Insert Name: ");
    username = Console.ReadLine();
    Console.WriteLine("Insert Password: ");
    password = Console.ReadLine();

    if (username == "Togrul" && password == "1234")
    {
    label2:
        Console.Clear();
        Console.WriteLine("1)Show Notifications\n2)Show Posts\n3)Add Post\n4)Back");

        string? cho;
        cho = Console.ReadLine();

        if (cho == "1")
        {
            Console.Clear();
            a1.ShowNotifications();
            Console.WriteLine("b.Back");
            string? b;
            b = Console.ReadLine();
            if (b == "b")
            {
                goto label2;
            }
        }


        else if (cho == "2")
        {
            Console.Clear();
            a1.ShowPosts();
            Console.WriteLine("b.Back");
            string? b;
            b = Console.ReadLine();
            if (b == "b")
            {
                goto label2;
            }
        }


        else if (cho == "3")
        {
            Console.Clear();
            string? content;
            Console.WriteLine("Insert Content: ");
            content = Console.ReadLine();

            Post post = new(content);
            a1.AddPost(post);

            Console.Clear();
            Console.WriteLine("Post Added");
            Console.WriteLine("b.Back");
            string? b;
            b = Console.ReadLine();
            if (b == "b")
            {
                goto label2;
            }
        }


        else if (cho == "4")
        {
            goto label;
        }


    }
}

else if (choose == "2")
{
    Console.Clear();
    string? email;
    string? password;

    Console.WriteLine("Insert Email: ");
    email = Console.ReadLine();

    Console.WriteLine("Insert Password: ");
    password = Console.ReadLine();

    foreach (var user in users)
    {
        if (user.Email == email && user.Password == password)
        {
            Console.Clear();
            a1.ShowPosts();

        label3:

            Console.WriteLine("1.Like \n2.Notification \n3.Back\n");
            string? ch;
            ch = Console.ReadLine();

            if (ch == "1")
            {
                int id;
                Console.WriteLine("Insert Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                a1.LikePostById(id);

                Console.WriteLine("Post Liked");
                Console.Clear();

                a1.ShowPosts();
                goto label3;
            }

            else if (ch == "2")
            {
                int id;
                Console.WriteLine("Insert Id: ");
                id = Convert.ToInt32(Console.ReadLine());


                string? text;
                Console.WriteLine("Insert text: ");
                text = Console.ReadLine();

                a1.AddNotification(id, text, user);
                Console.WriteLine("Notification send");

                string? c;
                Console.WriteLine("1.Admin \n2.Exit");
                c = Console.ReadLine();

                if (c == "1")
                {
                    goto label;
                }
                else if (c == "2")
                {
                    break;
                }
            }

            else if (ch == "3")
            {
                goto label;
            }
        }
    }
}