#include <iostream>
#include <vector>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int A, B, count = 0;
	cin >> A >> B;

	while (A < B)
	{
		if (!(B % 2))
			B /= 2;
		else if (1 == (B % 10))
			B /= 10;
		else
			break;

		++count;
	}

	if (A != B)
		cout << -1 << '\n';
	else
		cout << count + 1 << '\n';

	return 0;
}

// 혼자 풀어본 그지같은 코드
//void MakeB(int b, int& goal, int& result, int count)
//{
//	if (b < goal)
//		return;
//	else if (b == goal)
//	{
//		if (-1 == result)
//			result = count;
//		else
//			result = min(result, count);
//		
//		return;
//	}
//
//	if (!(b % 2))
//		MakeB(b / 2, goal, result, count + 1);
//	if (!((b - 1) % 10))
//		MakeB(b / 10, goal, result, count + 1);
//}
//
//int main(void)
//{
//	ios::sync_with_stdio(false);
//	cin.tie(NULL);
//	cout.tie(NULL);
//
//	int A, B, count = -1;
//	cin >> A >> B;
//
//	MakeB(B, A, count, 1);
//	
//	cout << count << '\n';
//
//	return 0;
//}