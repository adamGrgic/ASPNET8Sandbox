using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace SandboxModule.L33tC0d3
{
    // Two Sum
    // Difficulty Easy
    // Problem Link: https://leetcode.com/problems/two-sum/description/

    // Description
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.

    [Route("{controller}/{action}")]
    public class TwoSum : Controller
    {
        public IActionResult V1(int[] nums, int target)
        {
            // return indices of the two numbers in nums such that they add up to the target

            // I guess we could go through each item in the array and then check to see if each other element would add up to the target
            //

            for(var i = 0; i < nums.Length;i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                }
            }


            return Ok();
        }

        public int[] ExecuteSolution(int[] nums, int target) {


            var foo = new int[] { 1, 2, 3 };
            return foo;
        }
    }
}
