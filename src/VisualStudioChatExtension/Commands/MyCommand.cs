using Microsoft.VisualStudio.Shell.Interop;
using System.Threading.Tasks;
using VisualStudioChatExtension.Configuration;
using VisualStudioChatExtension.Views;

namespace VisualStudioChatExtension.Commands
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            ToolWindowPane window = await Package.ShowToolWindowAsync(typeof(ChatToolWindow), 0, true, Package.DisposalToken);
            if ((window == null) || (window.Frame == null))
            {
                throw new NotSupportedException("Cannot create tool window");
            }
            IVsWindowFrame windowFrame = (IVsWindowFrame)window.Frame;
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(windowFrame.Show());
        }
    }
}
