using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fællessystem.ViewModel.EventArgs
{
    public class NewVolunteerApplicationEventArgs
    {
        public List<Areas> AreaList { get; set; }

        public List<string> CommentList { get; set; }

        public NewVolunteerApplicationEventArgs()
        {
            AreaList = new List<Areas>();
            CommentList = new List<string>();
        }
    }
}
