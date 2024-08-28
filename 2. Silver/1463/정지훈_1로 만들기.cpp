#include <iostream>
#include <vector>

using namespace std;

int main(void)
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int N;
	cin >> N;

	vector<int> vecArray(N + 1);

	for (int i = 2; i <= N; ++i)
	{
		vecArray[i] = vecArray[i - 1] + 1;

		if (!(i % 3))
			vecArray[i] = min(vecArray[i], vecArray[i / 3] + 1);
		if (!(i % 2))
			vecArray[i] = min(vecArray[i], vecArray[i / 2] + 1);
	}

	cout << vecArray[N] << '\n';

	return 0;
}