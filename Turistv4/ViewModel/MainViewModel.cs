using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turistv4.Annotations;
using Turistv4.Common;
using Turistv4.Model;

namespace Turistv4.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private static ObservableCollection<Comment> _comments;
        private static CommentHandler _opretCommentHandler = new CommentHandler(_comments);
        private RelayCommand _opretCommentCommand;

        public static ObservableCollection<Comment> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public RelayCommand CreateCommentCommand
        {
            get { return _opretCommentCommand; }
            set { _opretCommentCommand = value; }
        }

        public static CommentHandler CreateCommentHandler
        {
            get { return _opretCommentHandler; }
            set { _opretCommentHandler = value; }
        }

        public MainViewModel()
        {
           

            CreateCommentCommand = new RelayCommand(_opretCommentHandler.CreateComment);
        }
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
