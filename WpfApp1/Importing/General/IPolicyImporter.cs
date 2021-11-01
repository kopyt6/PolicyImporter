using System;
using System.Collections.Generic;

namespace WpfApp1.Importing.General
{
    interface IPolicyImporter
    {
        Dictionary<String, PolicyObject> LoadData(String dir, String file);
    }
}
