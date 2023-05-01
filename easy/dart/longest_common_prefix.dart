// 14. Longest Common Prefix
// given a list of words find the common prefix, if any.
class Solution {
  String longestCommonPrefix(List<String> strings) {
    List<String> prefixCharacters = [];

    bool foundCommonPrefix = false;
    int index = 0;
    while (foundCommonPrefix == false) {
      for (var word in strings) {
        if (word.length <= index) {
          if (prefixCharacters.length == index + 1) {
            prefixCharacters.removeAt(index);
          }
          foundCommonPrefix = true;
          break;
        }

        var character = word[index];
        if (prefixCharacters.isEmpty || prefixCharacters.length < index + 1)
          prefixCharacters.add(character);

        if (character != prefixCharacters[index]) {
          prefixCharacters.removeAt(index);
          foundCommonPrefix = true;
          break;
        }
      }
      index++;
    }
    String result = "";
    prefixCharacters.forEach((char) {
      result = "$result$char";
    });
    return result;
  }
}
