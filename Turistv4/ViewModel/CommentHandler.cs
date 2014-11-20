using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turistv4.Model;

namespace Turistv4.ViewModel
{
    [Serializable]
    class CommentHandler
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

        public CommentHandler(ObservableCollection<Comment> comments)
        {
            _comments = comments;
        }

        public void CreateComment()
        {
          /*  FileStream toStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
            StreamWriter fileWriter = new StreamWriter(toStream);

            fileWriter.WriteLine("This");
            fileWriter.WriteLine("is");
            fileWriter.WriteLine("a");
            fileWriter.WriteLine("test!");

            fileWriter.Close();  //notice you have to close the StreamWriter before the FileStream
            toStream.Close();

            FileStream fromStream = new FileStream("data1.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader filReader = new StreamReader(fromStream);
           * */
        }

    }
}
