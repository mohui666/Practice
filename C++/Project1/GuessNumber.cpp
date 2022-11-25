#include <iostream>
#include <ctime>
using namespace std;

int main6()
{
	srand((unsigned int)time(NULL));
	int a = rand() % 10000 + 1;
	int b = 0;
	while (b <= 11)
	{	
		cout << "Input number you guessed(1~10000): ";
		int c;
		cin >> c;
		if (b>10) 
		{
			cout << "You Lost" << endl;
			break;
		}
		if (c == a)
		{
			cout << "You Win" << endl;
			b = 12;
		}
		else if (c < a)
		{
			cout << "Smaller" << endl;
			b++;
		}
		else 
		{
			cout << "Bigger" << endl ;
			b++;
		}	
	}

	return 0;
}