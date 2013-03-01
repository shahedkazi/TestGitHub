using System;
namespace GitTestApp
{
	interface IPerson
	{
		string Name();
        string DateOpened();
        string Address();
		string ToString();
//<<<<<<< HEAD
        int CompanyId();
//        string Abn();
        int NoOfEmployee();
//=======
        int Abn();
//>>>>>>> origin/firstBranch
	}
}