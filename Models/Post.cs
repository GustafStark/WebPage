using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMVer4.Models
{
    public class Post
    {
        public int PostID { get; set; }
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [DataType(DataType.ImageUrl)]
        public string PictureURL { get; set; }
        [DataType(DataType.Upload)]
        public string PictureUpload { get; set; }
        [DataType(DataType.Text)]
        public string ShortText { get; set; }

        [DataType(DataType.MultilineText)]
        public string InfoText { get; set; }

        public bool Visas { get; set; }

        [DataType(DataType.Text)]
        public string Arthur { get; set; }

        public virtual ICollection<Category> CategoryID { get; set; }

    }
}