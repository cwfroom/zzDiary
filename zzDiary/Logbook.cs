using System.Collections.Generic;

namespace zzDiary
{
    class LogbookFile {
        List<string> Categories;
        Dictionary<string, Dictionary<string, List<string>>> LogbookData;
    }

    public class Logbook
    {
        private MainWindow mainWindow;
        private string logbookFileName;


        public Logbook (MainWindow _mainWindow, string _logbookFileName)
        {
            this.mainWindow = _mainWindow;
            this.logbookFileName = _logbookFileName;
        }

    }
}
