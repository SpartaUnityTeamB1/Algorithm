#include <iostream>
#include <vector>
#include <queue>
#include <functional>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	priority_queue<int, vector<int>, greater<int>> pq;

	int N, Temp, Sum = 0;
	cin >> N;

	if (1 == N)
	{
		cout << 0 << '\n';
		return 0;
	}

	for (int i = 0; i < N; ++i)
	{
		cin >> Temp;

		pq.push(Temp);
	}

	while (!pq.empty())
	{
		Temp = pq.top();
		pq.pop();

		if (!pq.empty())
		{
			Temp += pq.top();
			pq.pop();

			if (!pq.empty())
				pq.push(Temp);
		}

		Sum += Temp;
	}

	cout << Sum << '\n';

	return 0;
}

// 얘가 더 나은 것 같기도
//#include <iostream>
//#include <vector>
//#include <queue>
//#include <functional>
//
//using namespace std;
//
//int main()
//{
//	ios::sync_with_stdio(false);
//	cin.tie(NULL);
//	cout.tie(NULL);
//
//	priority_queue<int, vector<int>, greater<int>> pq;
//
//	int N, Temp, A, B, Sum = 0;
//	cin >> N;
//
//	for (int i = 0; i < N; ++i)
//	{
//		cin >> Temp;
//
//		pq.push(Temp);
//	}
//
//	while (1 < pq.size())
//	{
//		A = pq.top();
//		pq.pop();
//		B = pq.top();
//		pq.pop();
//
//		Temp = A + B;
//		Sum += Temp;
//
//		pq.push(Temp);
//	}
//
//	cout << Sum << '\n';
//
//	return 0;
//}