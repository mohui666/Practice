#include <iostream>
using namespace std;

int main3() 
{
	int grades;
	cin >> grades; \
		if (grades == 150) 
		{
			cout << "��";
		}
		else if(grades < 150 && grades >= 0)
		{
			cout << "����";
		}
		else 
		{
			cout << "dinner";
		}
	return 0;
}