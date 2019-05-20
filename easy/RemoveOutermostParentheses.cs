using System.Collections.Generic;
using System.Text;
namespace Leetcode.easy
{
  public class RemoveOutermostParentheses
  {
    public string RemoveOuterParentheses(string S)
    {
        var sb = new StringBuilder();
        int left = 0,right = 0,index =0,prevEndIndex = -1;
        while(index<S.Length){

            if(S[index] == '(') left++;
            if(S[index] == ')') right++;

            if(left==right){
                sb.Append(S.Substring(prevEndIndex+2,index-prevEndIndex-2));
                prevEndIndex = index;
            }
            index++;
        }
        return sb.ToString();
    }
  }
}