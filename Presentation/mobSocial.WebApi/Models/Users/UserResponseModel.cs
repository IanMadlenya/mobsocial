﻿using System;
using System.Collections.Generic;
using mobSocial.Data.Enum;
using mobSocial.WebApi.Configuration.Mvc.Models;
using mobSocial.WebApi.Models.Education;
using mobSocial.WebApi.Models.Notifications;

namespace mobSocial.WebApi.Models.Users
{
    public class UserResponseModel : RootEntityModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string ProfileImageUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public string ProfileUrl { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateCreatedLocal { get; set; }

        public bool Active { get; set; }

        public DateTime? LastLoginDateUtc { get; set; }

        public DateTime? LastLoginDateLocal { get; set; }

        public int FollowerCount { get; set; }

        public int FollowingCount { get; set; }

        public int FriendCount { get; set; }

        public bool CanFollow { get; set; }

        public int FollowStatus { get; set; }

        public FriendStatus FriendStatus { get; set; }

        public IList<EducationResponseModel> Educations { get; set; }

        public List<NotificationModel> Notifications { get; set; }

        public int UnreadNotificationCount { get; set; }

        public bool IsOnline { get; set; }

        public string SeName { get; set; }

        public string Email { get; set; }

    }
}