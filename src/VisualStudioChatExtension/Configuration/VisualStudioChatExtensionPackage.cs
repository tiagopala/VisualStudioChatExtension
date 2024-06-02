global using Community.VisualStudio.Toolkit;
global using Microsoft.VisualStudio.Shell;
global using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using VisualStudioChatExtension.Commands;
using VisualStudioChatExtension.Views;

namespace VisualStudioChatExtension.Configuration
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.VisualStudioChatExtensionString)]
    [ProvideToolWindow(typeof(ChatToolWindow))]
    public sealed class VisualStudioChatExtensionPackage : ToolkitPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.RegisterCommandsAsync();
            await ChatToolWindowCommand.InitializeAsync(this);
        }
    }
}