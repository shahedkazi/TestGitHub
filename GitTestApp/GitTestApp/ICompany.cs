using System;
namespace GitTestApp
{
	interface IPerson
	{
		string Name();
        string DateOpened();
        string Address();
		string ToString();
        int CompanyId();
        string Abn();
        int NoOfEmployee();
	}
}