using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace VisualStudioChatExtension.Views
{
    /// <summary>
    /// Interaction logic for ChatUserControl.xaml
    /// </summary>
    public partial class ChatUserControl : UserControl
    {
        public ChatUserControl()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var messageText = InputBox.Text;
            if (!string.IsNullOrWhiteSpace(messageText))
            {
                AddMessageToChatPanel($"You: {messageText}", isUser: true);
                InputBox.Clear();

                // Simulate a bot response
                AddMessageToChatPanel($"Bot: Echo {messageText}", isUser: false);
            }
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                SendButton_Click(sender, e);
        }

        private void AddMessageToChatPanel(string message, bool isUser)
        {
            var messageBlock = new TextBlock
            {
                Text = message,
                Margin = new Thickness(5),
                Padding = new Thickness(10),
                Background = isUser ? System.Windows.Media.Brushes.LightGreen : System.Windows.Media.Brushes.LightGray,
                Foreground = System.Windows.Media.Brushes.Black,
                HorizontalAlignment = isUser ? HorizontalAlignment.Right : HorizontalAlignment.Left,
                MaxWidth = 300,
                TextWrapping = TextWrapping.Wrap
            };

            ChatPanel.Children.Add(messageBlock);
        }
    }
}
