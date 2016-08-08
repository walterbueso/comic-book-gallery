using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        //to add a title for each comic book
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " " + IssueNumber;
            }
        }

        //To get the cover image with name convention series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}