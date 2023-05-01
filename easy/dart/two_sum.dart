// 1. Two Sum
// get the indicies of two numbers that add up to the target number
class Solution {
  List<int> twoSum(List<int> numbers, int target) {
    List<int> result = [];
    for (int i = 0; i < numbers.length; i++) {
      int number1 = numbers[i];
      for (int j = i + 1; j < numbers.length; j++) {
        int number2 = numbers[j];
        if (number1 + number2 == target) {
          result.addAll([i, j]);
          return result;
        }
      }
    }
    return result;
  }
}
