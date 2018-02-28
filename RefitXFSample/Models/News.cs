using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RefitXFSample.Models
{
    public class Source
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Resolution
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Image
    {
        public Source Source { get; set; }
        public IList<Resolution> Resolutions { get; set; }
        public string Id { get; set; }
    }

    public class Preview
    {
        public IList<Image> Images { get; set; }
        public bool Enabled { get; set; }
    }
    public class NewsDetail
    {
        public string Domain { get; set; }
        public object ApprovedAtUtc { get; set; }
        public object ModReasonBy { get; set; }
        public object BannedBy { get; set; }
        public object NumReports { get; set; }
        public string SubredditId { get; set; }
        public int? ThumbnailWidth { get; set; }
        public string Subreddit { get; set; }
        public string SelftextHtml { get; set; }
        public string Selftext { get; set; }
        public object Likes { get; set; }
        public object SuggestedSort { get; set; }
        public IList<object> UserReports { get; set; }
        public object SecureMedia { get; set; }
        public bool IsRedditMediaDomain { get; set; }
        public string LinkFlairText { get; set; }
        public string Id { get; set; }
        public object BannedAtUtc { get; set; }
        public object ModReasonTitle { get; set; }
        public object ViewCount { get; set; }
        public bool Archived { get; set; }
        public bool Clicked { get; set; }
        public object ReportReasons { get; set; }
        public string Author { get; set; }
        public int NumCrossposts { get; set; }
        public bool Saved { get; set; }
        public IList<object> ModReports { get; set; }
        public bool CanModPost { get; set; }
        public bool IsCrosspostable { get; set; }
        public bool Pinned { get; set; }
        public int Score { get; set; }
        public object ApprovedBy { get; set; }
        public bool Over18 { get; set; }
        public bool Hidden { get; set; }
        public Preview Preview { get; set; }
        public string Thumbnail { get; set; }
        public bool Edited { get; set; }
        public string LinkFlairCssClass { get; set; }
        public object AuthorFlairCssClass { get; set; }
        public bool ContestMode { get; set; }
        public int Gilded { get; set; }
        public int Downs { get; set; }
        public bool BrandSafe { get; set; }
        public object RemovalReason { get; set; }
        public string PostHint { get; set; }
        public object AuthorFlairText { get; set; }
        public bool Stickied { get; set; }
        public bool CanGild { get; set; }
        public int? ThumbnailHeight { get; set; }
        public object ParentWhitelistStatus { get; set; }
        public string Name { get; set; }
        public bool Spoiler { get; set; }
        public string Permalink { get; set; }
        public string SubredditType { get; set; }
        public bool Locked { get; set; }
        public bool HideScore { get; set; }
        public string Created { get; set; }
        public string Url { get; set; }
        public object WhitelistStatus { get; set; }
        public bool Quarantine { get; set; }
        public string Title { get; set; }
        public string CreatedUtc { get; set; }
        public string SubredditNamePrefixed { get; set; }
        public int Ups { get; set; }
        public object Media { get; set; }
        public string NumComments { get; set; }
        public bool IsSelf { get; set; }
        public bool Visited { get; set; }
        public object ModNote { get; set; }
        public bool IsVideo { get; set; }
        public object Distinguished { get; set; }
    }

    public class News
    {
        public string Kind { get; set; }
        public NewsDetail Data { get; set; }
    }

    public class Data
    {
        public string After { get; set; }
        public int Dist { get; set; }
        public string Modhash { get; set; }
        public object WhitelistStatus { get; set; }

        [JsonProperty("Children")]
        public IList<News> News { get; set; }

        public object Before { get; set; }
    }

    public class RootNews
    {
        public string Kind { get; set; }
        public Data Data { get; set; }
    }

}
