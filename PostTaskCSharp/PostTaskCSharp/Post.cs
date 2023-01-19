﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNamespace
{
    internal class Post
    {
        public int Id { get; set; }
        public static int StaticId = 1;

        public string? Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int LikeCount { get; set; }
        public int VeiwCount { get; set; }

        public Post(string? content)
        {
            Id = StaticId++;
            Content = content;
            CreationDateTime = DateTime.Now;
            LikeCount = 0;
            VeiwCount = 0;
        }

        public override string ToString()
        {
            return $"Id: {Id} \nContent: {Content} \nCreation Date Time: {CreationDateTime} \nLike Count: {LikeCount} \nVeiw Count: {VeiwCount}\n";
        }
    }
}
