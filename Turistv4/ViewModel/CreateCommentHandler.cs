using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turistv4.Model;

namespace Turistv4.ViewModel
{
    class CreateCommentHandler
    {
        private ObservableCollection<Comment> _comments;
        private int _comRating;
        private String _comText;

        public int ComRating
        {
            get { return _comRating; }
            set { _comRating = value; }
        }

        public string ComText
        {
            get { return _comText; }
            set { _comText = value; }
        }

        public CreateCommentHandler(ObservableCollection<Comment> comments)
        {
            _comments = comments;
        }

        public void CreateComment()
        {
            Comment comment = new Comment(_comRating, _comText);
            _comments.Add(comment);
        }

    }
}
