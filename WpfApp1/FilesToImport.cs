using System;

namespace WpfApp1
{
    class FilesToImport
    {
        public String PathBaza { get; set; }
        public String PathWartaEagentWznowienia { get; set; }
        public String PathWartaEagentPolisy { get; set; }
        public String PathWartaXXI { get; set; }
        public String PathWartaManager { get; set; }
        public String PathPZU { get; set; }
        public String PathHestiaZadania { get; set; }
        public String PathHestiaPolisy { get; set; }
        public String PathMTUPolisy { get; set; }
        public String PathCompensa { get; set; }
        public String PathUniqa { get; set; }

        public FilesToImport()
        {
        }

        public override string ToString()
        {
            return PathBaza + '\n' + PathWartaEagentPolisy;
        }
    }
}
