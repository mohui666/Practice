#include <iostream>
using namespace std;

int main()
{
	int arr[] = { 1,2,3,4,5 };
	cout << sizeof(arr) << endl;
	cout << sizeof(arr[0]) << endl;
	cout << arr <<endl;
	cout << &arr[0];
	return 0;
}