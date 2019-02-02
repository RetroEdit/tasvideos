﻿using TASVideos.Data;
using TASVideos.Data.Constants;
using TASVideos.Models;

namespace TASVideos.Pages.Forum.Posts.Models
{
	public class UserPostsRequest : PagedModel
	{
		public UserPostsRequest()
		{
			PageSize = ForumConstants.PostsPerPage;
			SortDescending = true;
			SortBy = nameof(UserPostsModel.Post.CreateTimestamp);
		}
	}
}
