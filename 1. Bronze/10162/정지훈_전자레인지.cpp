#include <iostream>
#include <vector>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int T, A, B, C;
	cin >> T;

	if (0 != (T % 10))
		cout << -1 << '\n';
	else
	{
		A = T / 300;
		B = (T % 300) / 60;
		C = ((T % 300) % 60) / 10;

		cout << A << ' ' << B << ' ' << C << '\n';
	}

	return 0;
}

// 수정 쓰레기 코드
//#include <iostream>
//#include <vector>
//
//using namespace std;
//
//int main()
//{
//	ios::sync_with_stdio(false);
//	cin.tie(NULL);
//	cout.tie(NULL);
//
//	int T, A, B, C;
//	cin >> T;
//
//	if (0 != (T % 10))
//		cout << -1 << '\n';
//	else
//	{
//		A = T / 300;
//		T %= 300;
//		B = T / 60;
//		T %= 60;
//		C = T / 10;
//		T %= 10;
//
//		cout << A << ' ' << B << ' ' << C << '\n';
//	}
//
//	return 0;
//}

// 첫 쓰레기 코드
//#include <iostream>
//#include <vector>
//
//using namespace std;
//
//int main()
//{
//	ios::sync_with_stdio(false);
//	cin.tie(NULL);
//	cout.tie(NULL);
//
//	vector<int> vecCount(3);
//	bool canMake = false;
//	int T, A = 300, B = 60, C = 10;
//	cin >> T;
//
//	while (T > 0)
//	{
//		if (T >= A)
//		{
//			canMake = true;
//			++vecCount[0];
//			T -= A;
//		}
//		else if (T >= B)
//		{
//			canMake = true;
//			++vecCount[1];
//			T -= B;
//		}
//		else if (T >= C)
//		{
//			canMake = true;
//			++vecCount[2];
//			T -= C;
//		}
//		else
//			break;
//	}
//
//	if (!canMake || (0 != T))
//		cout << -1 << '\n';
//	else
//	{
//		for (int i = 0; i < vecCount.size(); ++i)
//			cout << vecCount[i] << ' ';
//		cout << '\n';
//	}
//
//	return 0;
//}