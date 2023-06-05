using System.Runtime.InteropServices;

namespace DotNetOxford.ProxyDemo.Services;

public class MessageService
{
    private const uint MB_YESNO = 0x4;

    public void DisplayMessageBox(string prompt, string title)
    {
        MessageBox(IntPtr.Zero, prompt, title, MB_YESNO);
    }

    [DllImport("user32.dll")]
    private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
}