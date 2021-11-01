using System;

namespace WpfApp1.Importing.General
{
    interface IPolicyCreator
    {
        PolicyObject CreatePolicy(String[] dataRow, IndexFinder indexFinder);
    }
}
