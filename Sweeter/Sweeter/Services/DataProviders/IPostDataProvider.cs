﻿using System.Collections.Generic;

namespace Sweeter.DataProviders
{
    using Models;

    public interface IPostDataProvider
    {
        IEnumerable<PostsModel> GetPosts();
        IEnumerable<PostsModel> GetPostsOfAuthor( int idauthor);
        PostsModel GetPost(int id);
       
        void DeletePost(int id);
     void AddPost(PostsModel post);
       void UpdatePost(PostsModel post);


    }
}