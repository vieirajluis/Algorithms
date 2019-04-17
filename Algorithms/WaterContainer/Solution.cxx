#include <math.h>
#include <vector>
class Solution {
public:
    int maxArea(vector<int>& height) 
    {
        int test = 0;
        for (int i = 0; i < height.size(); i++)
            for (int j = i + 1; j < height.size(); j++)
                test = fmax(test, fmin(height[i], height[j]) * (j - i));
        return test;
    }
};