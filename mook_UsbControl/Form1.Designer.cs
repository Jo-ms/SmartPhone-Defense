using Microsoft.Win32;
namespace mook_UsbControl
{
    partial class Form1
    {
        enum Permission { Allow = 3, Deny = 4 };
        RegistryKey key = Registry.LocalMachine.OpenSubKey(@"PATH", true);

        private System.ComponentModel.IContainer components = null;    

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 60);
            
            key.SetValue("Start", (int)Permission.Deny);    // 차단
            //key.SetValue("Start", (int)Permission.Allow);     // 연결 
        }
    }
}

