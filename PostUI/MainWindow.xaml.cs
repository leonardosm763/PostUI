using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PostUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void postButton_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post(titleBox.Text, descriptionBox.Text);

            titleViewBlock.Text = post.Title;
            descriptionViewBlock.Text = post.Description;
            dateBlock.Text = post.TimeCreated.ToString();
        }

        private void upVoteButton_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post(titleBox.Text, descriptionBox.Text);

            post.UpVote();
            upVoteBlock.Text = post.UpVotes.ToString();
        }

        private void downVoteButton_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post(titleBox.Text, descriptionBox.Text);

            post.DownVote();
            downVoteBlock.Text = post.DownVotes.ToString();
        }
    }
}
