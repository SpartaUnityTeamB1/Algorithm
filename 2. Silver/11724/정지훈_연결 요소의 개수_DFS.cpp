#include <iostream>
#include <vector>

using namespace std;

void DFS(int index, vector<bool>& rVisit, vector<vector<int>>& rArray)
{
	rVisit[index] = true;

	for (int i = 0; i < rArray[index].size(); ++i)
	{
		if (!rVisit[rArray[index][i]])
			DFS(rArray[index][i], rVisit, rArray);
	}
}

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int N, M, u, v, count = 0;
	cin >> N >> M;

	vector<vector<int>> vecArray(N + 1, vector<int>());
	vector<bool> vecVisit(N + 1);

	for (int i = 0; i < M; ++i)
	{
		cin >> u >> v;

		vecArray[u].push_back(v);
		vecArray[v].push_back(u);
	}

	for (int i = 1; i <= N; ++i)
	{
		if (!vecVisit[i])
		{
			++count;
			DFS(i, vecVisit, vecArray);
		}
	}

	cout << count << '\n';

	return 0;
}

// 혼자 풀어본 그지같은 코드
//bool DFS(int start, vector<vector<int>>& rArray, vector<vector<int>>& rVisit, int& count)
//{
//	bool isCount = false;
//
//	for (int j = 0; j < rArray[start].size(); ++j)
//	{
//		if (0 > rVisit[start][rArray[start][j]])
//		{
//			rVisit[start][rArray[start][j]] = rVisit[rArray[start][j]][start] = count;
//
//			DFS(rArray[start][j], rArray, rVisit, count);
//			isCount = true;
//		}
//	}
//
//	return isCount;
//}
//
//int main()
//{
//	ios::sync_with_stdio(false);
//	cin.tie(NULL);
//	cout.tie(NULL);
//
//	int N, M, u, v, count = 0;
//	cin >> N >> M;
//
//	vector<vector<int>> vecArray(N + 1, vector<int>());
//	vector<vector<int>> vecVisit(N + 1, vector<int>(N + 1, -1));
//
//	for (int i = 0; i < M; ++i)
//	{
//		cin >> u >> v;
//
//		vecArray[u].push_back(v);
//		vecArray[v].push_back(u);
//	}
//
//	for (int i = 1; i <= N; ++i)
//	{
//		if (!vecArray[i].size() || DFS(i, vecArray, vecVisit, count))
//			++count;
//	}
//		
//	cout << count << '\n';
//
//	return 0;
//}