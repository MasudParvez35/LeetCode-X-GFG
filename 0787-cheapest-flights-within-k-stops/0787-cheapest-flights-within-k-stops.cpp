class Solution {
public:
    vector<vector<pair<int,int>>> ar;
    vector <int> dist;
    void dijkstra(int start, int k)
    {
        queue <pair<int,int>> q;
        q.push({start, 0});
        dist[start] = 0;
        while(q.size() and k >= 0)
        {
            k--;
            int len = q.size();
            for (int i = 0; i < len; i++)
            {
                int node = q.front().first;
                int d = q.front().second;
                q.pop();
                for (auto it : ar[node])
                {
                    int child = it.first;
                    int w = it.second;
                    if (dist[child] > d + w)
                    {
                        dist[child] = d + w;
                        q.push({child, dist[child]});
                    }
                }
            }
        }
    }
    int findCheapestPrice(int n, vector<vector<int>>& a, int x, int y, int k) 
    {
        ar.resize(n);
        dist.assign(n+5,INT_MAX);
        for (auto i : a) {
            ar[i[0]].push_back({i[1],i[2]});
        }
        dijkstra(x,k);
        return dist[y] == INT_MAX ? -1 : dist[y];
    }
};
