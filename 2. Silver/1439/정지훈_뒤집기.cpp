#include <iostream>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int count = 0;
	string strInput;
	cin >> strInput;

	for (int i = 0; i < strInput.length(); ++i)
	{
		if (strInput[i] != strInput[i + 1])
			++count;
	}

	cout << count / 2 << '\n';

	return 0;
}