using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema_2 : MonoBehaviour
{
    class Solution {
    public int[] twoSum(int[] nums, int target) {
        int[] numT = {-1,-1};
        
        for(int i=0;i<nums.length-1; i++)
        {
            boolean flag = false;
            for(int j=i+1; j<nums.length; j++){
                if((nums[i] + nums[j]) == target)
                {
                    numT[0] = i;
                    numT[1] = j;
                    flag = true;
                    break;
                } 
                if(flag)
                    break;
            
            }
        }
        return numT;
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
