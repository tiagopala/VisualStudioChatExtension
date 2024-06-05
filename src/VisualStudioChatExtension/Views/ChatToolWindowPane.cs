using System.Runtime.InteropServices;
using VisualStudioChatExtension.Commands;

namespace VisualStudioChatExtension.Views
{
    [Guid("54e0c44d-badb-4c32-ade9-bef550437cdb")]
    public class ChatToolWindowPane : ToolWindowPane
    {
        public ChatToolWindowPane() : base(null)
        {
            this.Caption = "StackSpot AI Chat";
            this.Content = new Commands.ChatUserControl();
        }
    }
}
