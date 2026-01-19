class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        

         unordered_map<int,int> mymap ;
        vector<int> indexes;
    
        for(int i = 0 ;i<nums.size();i++)
            {
                int mapval =0;
                mapval=target - nums[i];
                if( mymap.find(mapval)== mymap.end())
                    mymap.insert({nums[i],i});
                else
                { 
                    indexes.push_back(mymap[mapval]);
                    indexes.push_back(i);
                    break;
                }
                    
            }
        
        return indexes;
    }
};