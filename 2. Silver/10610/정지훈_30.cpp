#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int Sum = 0;
	bool isTen = false;
	string Input;
	cin >> Input;

	sort(Input.begin(), Input.end(), greater<char>());

	for (int i = 0; i < Input.length(); ++i)
	{
		if ('0' == Input[i])
			isTen = true;

		Sum += static_cast<int>(Input[i]);
	}

	if (isTen && !(Sum % 3))
		cout << Input << '\n';
	else
		cout << -1 << '\n';

	return 0;
}